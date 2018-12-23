using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PeopleApp.Shared;
using PeopleApp.Shared.Entities;

namespace PeopleApp
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc()
        .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
        .AddFeatureFolders();

      services.AddCors(options =>
      {
        options.AddPolicy("AllowAll",
          builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .AllowCredentials());
      });

      services.AddMediatR(GetType().Assembly);

      var context = new ApiContext(ApiContext.SqliteOptions);

      SeedData(context);

      services.AddSingleton(context);
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      Mapper.Initialize(cfg => cfg.AddProfiles(GetType().Assembly));

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseHsts();
      }

      app.UseCors("AllowAll");
      //app.UseHttpsRedirection();
      app.UseMvc();
    }

    public void SeedData(ApiContext context)
    {
      context.Database.EnsureDeleted();
      context.Database.EnsureCreated();

      foreach (var interest in SampleData.Interests)
      {
        context.Interests.Add(interest);
      }

      context.SaveChanges();

      foreach (var person in SampleData.People)
      {
        person.PersonInterests = new List<PersonInterest>();
        context.People.Add(person);
      }

      context.SaveChanges();

      foreach (var person in context.People)
      {
        if (String.IsNullOrWhiteSpace(person.Colors)) continue;

        var colors = person.Colors.Split(',');

        foreach (var color in colors)
        {
          var interest = context.Interests.First(i => i.Color == color.Trim());

          person.PersonInterests.Add(new PersonInterest { Person = person, Interest = interest });

          //context.ChangeTracker.DetectChanges(); //debug
          //var entries = context.ChangeTracker.Entries().Where(e=>e.Entity is Interest).ToList();  //debug
        }
      }

      context.SaveChanges();
    }
  }
}
