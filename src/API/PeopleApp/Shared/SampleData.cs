using PeopleApp.Shared.Entities;

namespace PeopleApp.Shared
{
  public static class SampleData
  {
    public static readonly Interest[] Interests = new Interest[]
    {
      // red|orange|yellow|green|blue|indigo|violet
      new Interest
      {
        Color = "red",
        Name = "surfing"
      },
      new Interest
      {
        Color = "orange",
        Name = "yoga"
      },
      new Interest
      {
        Color = "yellow",
        Name = "running"
      },
      new Interest
      {
        Color = "green",
        Name = "swimming"
      },
      new Interest
      {
        Color = "blue",
        Name = "hang gliding"
      },
      new Interest
      {
        Color = "indigo",
        Name = "hiking"
      },
      new Interest
      {
        Color = "violet",
        Name = "knitting"
      },
    };
    public static readonly Person[] People = new Person[]
    {
      new Person
      {
        FirstName = "Noelle", LastName = "Roy", Email = "sem.vitae.aliquam@Seddictum.edu",
        Photo = "https://randomuser.me/api/portraits/women/0.jpg", Age = 32,
        StreetAddress = "P.O. Box 274, 8083 Nisl Rd.", City = "Seattle", State = "WA", Zip = "14496",
        Colors = "orange"
      },
      new Person
      {
        FirstName = "Nyssa", LastName = "Sargent", Email = "orci.quis@magnisdisparturient.org",
        Photo = "https://randomuser.me/api/portraits/women/1.jpg", Age = 29, StreetAddress = "8756 Amet, St.",
        City = "Denver", State = "Colorado", Zip = "73269", Colors = "red, yellow, orange, green, blue"
      },
      new Person
      {
        FirstName = "Shellie", LastName = "Haley", Email = "luctus@miAliquamgravida.ca",
        Photo = "https://randomuser.me/api/portraits/women/2.jpg", Age = 45,
        StreetAddress = "P.O. Box 559, 2669 Urna Rd.", City = "Tuscaloosa", State = "Alabama", Zip = "35736",
        Colors = "green, indigo, yellow"
      },
      new Person
      {
        FirstName = "Althea", LastName = "Hester", Email = "ornare@iaculis.com",
        Photo = "https://randomuser.me/api/portraits/women/3.jpg", Age = 24,
        StreetAddress = "Ap #577-5342 Neque Street", City = "New Orleans", State = "Louisiana", Zip = "34392",
        Colors = "yellow"
      },
      new Person
      {
        FirstName = "Faith", LastName = "Marshall", Email = "sodales@porttitor.ca",
        Photo = "https://randomuser.me/api/portraits/women/4.jpg", Age = 42,
        StreetAddress = "P.O. Box 532, 5213 Adipiscing. Av.", City = "West Valley City", State = "Utah",
        Zip = "59812", Colors = "violet, green, indigo"
      },
      new Person
      {
        FirstName = "Madaline", LastName = "Grant", Email = "magna.Duis@acrisusMorbi.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/5.jpg", Age = 57, StreetAddress = "731-4535 Ac Avenue",
        City = "Lakewood", State = "Colorado", Zip = "70628", Colors = "yellow, blue"
      },
      new Person
      {
        FirstName = "Rhonda", LastName = "Keith", Email = "Sed@mitempor.ca",
        Photo = "https://randomuser.me/api/portraits/women/6.jpg", Age = 21, StreetAddress = "780-441 Neque. St.",
        City = "Laramie", State = "Wyoming", Zip = "39453", Colors = "red, yellow, violet"
      },
      new Person
      {
        FirstName = "Mira", LastName = "Chaney", Email = "Suspendisse@consectetuer.net",
        Photo = "https://randomuser.me/api/portraits/women/7.jpg", Age = 32, StreetAddress = "452-6916 A Road",
        City = "Metairie", State = "Louisiana", Zip = "33724", Colors = ""
      },
      new Person
      {
        FirstName = "Adena", LastName = "Townsend", Email = "rutrum@sociosquadlitora.ca",
        Photo = "https://randomuser.me/api/portraits/women/8.jpg", Age = 31, StreetAddress = "177-3575 Sodales Street",
        City = "Chesapeake", State = "Virginia", Zip = "47073", Colors = "blue, indigo, red"
      },
      new Person
      {
        FirstName = "Sage", LastName = "Woodward", Email = "Nunc@ac.net",
        Photo = "https://randomuser.me/api/portraits/women/9.jpg", Age = 57, StreetAddress = "587-8671 Egestas St.",
        City = "Gary", State = "Indiana", Zip = "45451", Colors = "blue, red, indigo, green, violet"
      },
      new Person
      {
        FirstName = "TaShya", LastName = "Hunter", Email = "semper.et.lacinia@magnamalesuadavel.com",
        Photo = "https://randomuser.me/api/portraits/women/10.jpg", Age = 36,
        StreetAddress = "P.O. Box 689, 3379 Cursus Road", City = "Southaven", State = "MS", Zip = "23550",
        Colors = "orange, indigo, blue, red, yellow"
      },
      new Person
      {
        FirstName = "Violet", LastName = "Mason", Email = "tortor.nibh@malesuadafamesac.com",
        Photo = "https://randomuser.me/api/portraits/women/11.jpg", Age = 48, StreetAddress = "548-5964 Non, St.",
        City = "Nampa", State = "ID", Zip = "68355", Colors = "red"
      },
      new Person
      {
        FirstName = "Sarah", LastName = "Lott", Email = "a.enim.Suspendisse@quis.net",
        Photo = "https://randomuser.me/api/portraits/women/12.jpg", Age = 32,
        StreetAddress = "Ap #127-9483 Semper, Street", City = "Salem", State = "Oregon", Zip = "13354",
        Colors = "indigo, red"
      },
      new Person
      {
        FirstName = "Blaine", LastName = "Horton", Email = "Cum.sociis@augue.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/13.jpg", Age = 53, StreetAddress = "100-8646 Nonummy. Road",
        City = "Salt Lake City", State = "Utah", Zip = "17746", Colors = "green, red, indigo"
      },
      new Person
      {
        FirstName = "Gwendolyn", LastName = "Hubbard", Email = "Cras.eget.nisi@inconsectetueripsum.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/14.jpg", Age = 31, StreetAddress = "518-317 Quam Av.",
        City = "Lewiston", State = "Maine", Zip = "93642", Colors = "indigo, red"
      },
      new Person
      {
        FirstName = "Doris", LastName = "Duncan", Email = "aliquet.metus.urna@at.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/15.jpg", Age = 20,
        StreetAddress = "P.O. Box 358, 6125 Pellentesque Av.", City = "Mesa", State = "AZ", Zip = "85831",
        Colors = "red, orange, violet"
      },
      new Person
      {
        FirstName = "Suki", LastName = "Leonard", Email = "sapien.Aenean@pede.net",
        Photo = "https://randomuser.me/api/portraits/women/16.jpg", Age = 37,
        StreetAddress = "Ap #714-2507 Diam Avenue", City = "Las Vegas", State = "Nevada", Zip = "90024",
        Colors = ""
      },
      new Person
      {
        FirstName = "Lucy", LastName = "Jensen", Email = "nunc.est@elit.net",
        Photo = "https://randomuser.me/api/portraits/women/17.jpg", Age = 63, StreetAddress = "725-6521 Laoreet, Rd.",
        City = "Philadelphia", State = "Pennsylvania", Zip = "20467", Colors = ""
      },
      new Person
      {
        FirstName = "Astra", LastName = "Robles", Email = "sed.facilisis@eratnequenon.ca",
        Photo = "https://randomuser.me/api/portraits/women/18.jpg", Age = 62, StreetAddress = "6418 Lobortis St.",
        City = "Norman", State = "Oklahoma", Zip = "30962", Colors = "indigo, green, yellow, orange, red"
      },
      new Person
      {
        FirstName = "Ciara", LastName = "Tucker", Email = "odio.vel@amet.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/19.jpg", Age = 62, StreetAddress = "4775 Ultricies Avenue",
        City = "Rock Springs", State = "WY", Zip = "55794", Colors = "yellow, green, violet"
      },
      new Person
      {
        FirstName = "Abigail", LastName = "Cooper", Email = "Nam@nectempusmauris.ca",
        Photo = "https://randomuser.me/api/portraits/women/20.jpg", Age = 65, StreetAddress = "549-8390 Blandit Street",
        City = "Portland", State = "ME", Zip = "19746", Colors = ""
      },
      new Person
      {
        FirstName = "Eleanor", LastName = "Richards", Email = "Aenean.sed.pede@pharetraQuisque.net",
        Photo = "https://randomuser.me/api/portraits/women/21.jpg", Age = 37, StreetAddress = "1540 Tellus Rd.",
        City = "Bellevue", State = "NE", Zip = "26410", Colors = "green, violet, orange, indigo"
      },
      new Person
      {
        FirstName = "Quin", LastName = "Page", Email = "arcu@Morbinon.net",
        Photo = "https://randomuser.me/api/portraits/women/22.jpg", Age = 18, StreetAddress = "5284 Nulla Road",
        City = "Rutland", State = "Vermont", Zip = "42158", Colors = ""
      },
      new Person
      {
        FirstName = "Jescie", LastName = "Baker", Email = "suscipit@duiinsodales.net",
        Photo = "https://randomuser.me/api/portraits/women/23.jpg", Age = 35, StreetAddress = "9419 Montes, Avenue",
        City = "Nashville", State = "TN", Zip = "60725", Colors = "red, indigo, orange"
      },
      new Person
      {
        FirstName = "Sara", LastName = "Valentine", Email = "ultrices@ipsum.net",
        Photo = "https://randomuser.me/api/portraits/women/24.jpg", Age = 27, StreetAddress = "Ap #150-9004 Et, Av.",
        City = "Missoula", State = "MT", Zip = "99315", Colors = "orange"
      },
      new Person
      {
        FirstName = "Hedwig", LastName = "Taylor", Email = "ut@adipiscingfringilla.edu",
        Photo = "https://randomuser.me/api/portraits/women/25.jpg", Age = 40, StreetAddress = "875-9042 Eu Av.",
        City = "Juneau", State = "AK", Zip = "99593", Colors = "blue, red, yellow, orange"
      },
      new Person
      {
        FirstName = "Regan", LastName = "Saunders", Email = "euismod.et.commodo@laoreet.ca",
        Photo = "https://randomuser.me/api/portraits/women/26.jpg", Age = 37, StreetAddress = "1847 Non, Avenue",
        City = "Boston", State = "Massachusetts", Zip = "21279", Colors = "violet, green, red, yellow"
      },
      new Person
      {
        FirstName = "Farrah", LastName = "Mays", Email = "dignissim.lacus@liberoduinec.com",
        Photo = "https://randomuser.me/api/portraits/women/27.jpg", Age = 52, StreetAddress = "Ap #791-6995 Sed Street",
        City = "Virginia Beach", State = "VA", Zip = "56800", Colors = "orange, blue"
      },
      new Person
      {
        FirstName = "TaShya", LastName = "Pratt", Email = "aliquet.Phasellus@miDuis.net",
        Photo = "https://randomuser.me/api/portraits/women/28.jpg", Age = 47, StreetAddress = "630-7065 Eget Avenue",
        City = "Fort Worth", State = "TX", Zip = "36165", Colors = ""
      },
      new Person
      {
        FirstName = "Amy", LastName = "Myers", Email = "odio.Etiam@nisl.org",
        Photo = "https://randomuser.me/api/portraits/women/29.jpg", Age = 44,
        StreetAddress = "P.O. Box 225, 9961 Habitant Rd.", City = "Dallas", State = "Texas", Zip = "20374",
        Colors = "indigo, red"
      },
      new Person
      {
        FirstName = "Ainsley", LastName = "Mercer", Email = "Proin@odioAliquam.ca",
        Photo = "https://randomuser.me/api/portraits/women/30.jpg", Age = 48,
        StreetAddress = "P.O. Box 605, 5021 Montes, Av.", City = "Green Bay", State = "Wisconsin", Zip = "68800",
        Colors = "green, blue, violet, orange, indigo"
      },
      new Person
      {
        FirstName = "Willa", LastName = "Henson", Email = "adipiscing.ligula@enimcommodo.net",
        Photo = "https://randomuser.me/api/portraits/women/31.jpg", Age = 25, StreetAddress = "486-2385 Nunc. Rd.",
        City = "Covington", State = "KY", Zip = "24846", Colors = ""
      },
      new Person
      {
        FirstName = "Hadassah", LastName = "Ortiz", Email = "ut.odio@orcilobortisaugue.net",
        Photo = "https://randomuser.me/api/portraits/women/32.jpg", Age = 60,
        StreetAddress = "Ap #595-2360 Convallis Street", City = "Hattiesburg", State = "Mississippi", Zip = "17431",
        Colors = ""
      },
      new Person
      {
        FirstName = "Audra", LastName = "Gill", Email = "mi@urna.org",
        Photo = "https://randomuser.me/api/portraits/women/33.jpg", Age = 55, StreetAddress = "647-2255 Blandit Rd.",
        City = "Southaven", State = "MS", Zip = "39070", Colors = "indigo, red, blue, green, violet"
      },
      new Person
      {
        FirstName = "Yvette", LastName = "Wood", Email = "semper.Nam@sitametdiam.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/34.jpg", Age = 31,
        StreetAddress = "P.O. Box 273, 6598 Aliquam St.", City = "Springfield", State = "Illinois", Zip = "84996",
        Colors = ""
      },
      new Person
      {
        FirstName = "Rhiannon", LastName = "Kane", Email = "magna.Ut.tincidunt@dolordapibus.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/35.jpg", Age = 48, StreetAddress = "8749 Ac Ave",
        City = "Idaho Falls", State = "Idaho", Zip = "48726", Colors = "indigo, red, violet, green"
      },
      new Person
      {
        FirstName = "Kerry", LastName = "Hernandez", Email = "mi.eleifend.egestas@nonenimMauris.edu",
        Photo = "https://randomuser.me/api/portraits/women/36.jpg", Age = 46, StreetAddress = "311 Dui. Av.",
        City = "Lexington", State = "Kentucky", Zip = "43760", Colors = "indigo, yellow, red"
      },
      new Person
      {
        FirstName = "Tara", LastName = "Smith", Email = "sit.amet@eleifendvitae.org",
        Photo = "https://randomuser.me/api/portraits/women/37.jpg", Age = 24,
        StreetAddress = "Ap #754-4560 Phasellus Road", City = "Reno", State = "NV", Zip = "62172",
        Colors = "yellow, green, blue, orange"
      },
      new Person
      {
        FirstName = "Stacy", LastName = "Wilson", Email = "vel@tellusfaucibus.net",
        Photo = "https://randomuser.me/api/portraits/women/38.jpg", Age = 35,
        StreetAddress = "Ap #287-1185 Justo. Avenue", City = "Montgomery", State = "AL", Zip = "35335",
        Colors = "violet, indigo, red, yellow"
      },
      new Person
      {
        FirstName = "Maia", LastName = "Galloway", Email = "leo@ultricessit.edu",
        Photo = "https://randomuser.me/api/portraits/women/39.jpg", Age = 50,
        StreetAddress = "Ap #700-5994 Diam. Street", City = "Shreveport", State = "Louisiana", Zip = "99480",
        Colors = "green, yellow"
      },
      new Person
      {
        FirstName = "Nyssa", LastName = "Ramirez", Email = "sed@Loremipsumdolor.edu",
        Photo = "https://randomuser.me/api/portraits/women/40.jpg", Age = 44,
        StreetAddress = "P.O. Box 993, 8483 Pellentesque, Ave", City = "Seattle", State = "WA", Zip = "35378",
        Colors = ""
      },
      new Person
      {
        FirstName = "Vera", LastName = "Maynard", Email = "facilisis.facilisis@ipsumsodales.edu",
        Photo = "https://randomuser.me/api/portraits/women/41.jpg", Age = 20,
        StreetAddress = "P.O. Box 428, 7941 Netus Ave", City = "Fort Worth", State = "TX", Zip = "45323",
        Colors = ""
      },
      new Person
      {
        FirstName = "Mary", LastName = "Randolph", Email = "ac.metus@nec.net",
        Photo = "https://randomuser.me/api/portraits/women/42.jpg", Age = 48, StreetAddress = "1949 Dui Rd.",
        City = "Hillsboro", State = "OR", Zip = "77697", Colors = ""
      },
      new Person
      {
        FirstName = "Shay", LastName = "Gregory", Email = "Suspendisse.commodo@Curabitursed.edu",
        Photo = "https://randomuser.me/api/portraits/women/43.jpg", Age = 38, StreetAddress = "Ap #160-5259 Tempus St.",
        City = "St. Petersburg", State = "Florida", Zip = "66849", Colors = "red, yellow, violet, indigo"
      },
      new Person
      {
        FirstName = "Quyn", LastName = "Chapman", Email = "Ut@neccursusa.ca",
        Photo = "https://randomuser.me/api/portraits/women/44.jpg", Age = 56, StreetAddress = "792-2978 A Rd.",
        City = "Vancouver", State = "Washington", Zip = "24807", Colors = "violet, indigo, green, yellow, orange"
      },
      new Person
      {
        FirstName = "Cally", LastName = "Jacobson", Email = "Pellentesque.habitant@gravidamolestiearcu.org",
        Photo = "https://randomuser.me/api/portraits/women/45.jpg", Age = 33,
        StreetAddress = "Ap #887-9026 Ridiculus Avenue", City = "Tallahassee", State = "FL", Zip = "13218",
        Colors = "green"
      },
      new Person
      {
        FirstName = "Clare", LastName = "Strickland", Email = "neque.pellentesque.massa@Quisque.org",
        Photo = "https://randomuser.me/api/portraits/women/46.jpg", Age = 46, StreetAddress = "342-3644 Sed Avenue",
        City = "Warren", State = "MI", Zip = "32658", Colors = ""
      },
      new Person
      {
        FirstName = "Daphne", LastName = "Benjamin", Email = "erat.Sed.nunc@convallis.net",
        Photo = "https://randomuser.me/api/portraits/women/47.jpg", Age = 32, StreetAddress = "749-1987 Vehicula Rd.",
        City = "Springdale", State = "AR", Zip = "72795", Colors = "yellow, blue, orange, violet"
      },
      new Person
      {
        FirstName = "Heather", LastName = "Norris", Email = "semper.et.lacinia@odioauctorvitae.org",
        Photo = "https://randomuser.me/api/portraits/women/48.jpg", Age = 26,
        StreetAddress = "P.O. Box 918, 1663 Nullam Road", City = "Flint", State = "Michigan", Zip = "22839",
        Colors = ""
      },
      new Person
      {
        FirstName = "Grace", LastName = "Stanton", Email = "Aenean.massa@Donecegestas.net",
        Photo = "https://randomuser.me/api/portraits/women/49.jpg", Age = 38, StreetAddress = "3923 Urna. Rd.",
        City = "Spokane", State = "Washington", Zip = "84890", Colors = "yellow, blue, red, violet, orange"
      },
      new Person
      {
        FirstName = "Angelica", LastName = "Gutierrez", Email = "Donec.est@amet.net",
        Photo = "https://randomuser.me/api/portraits/women/50.jpg", Age = 43, StreetAddress = "8132 Mattis. Street",
        City = "Richmond", State = "Virginia", Zip = "64617", Colors = ""
      },
      new Person
      {
        FirstName = "Serina", LastName = "Conley", Email = "hendrerit.consectetuer@magnaaneque.org",
        Photo = "https://randomuser.me/api/portraits/women/51.jpg", Age = 45, StreetAddress = "Ap #554-7171 Mauris St.",
        City = "Bozeman", State = "MT", Zip = "11533", Colors = "yellow"
      },
      new Person
      {
        FirstName = "Idola", LastName = "Rollins", Email = "nec.orci.Donec@milorem.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/52.jpg", Age = 51,
        StreetAddress = "P.O. Box 860, 554 Velit. Avenue", City = "Akron", State = "Ohio", Zip = "27483",
        Colors = "indigo, green, blue, red"
      },
      new Person
      {
        FirstName = "Jacqueline", LastName = "Scott", Email = "Vivamus.nisi.Mauris@ligulaconsectetuerrhoncus.ca",
        Photo = "https://randomuser.me/api/portraits/women/53.jpg", Age = 25, StreetAddress = "4722 Tincidunt Street",
        City = "Pocatello", State = "ID", Zip = "97070", Colors = "indigo"
      },
      new Person
      {
        FirstName = "Mechelle", LastName = "Mcfarland", Email = "eget.ipsum@bibendum.org",
        Photo = "https://randomuser.me/api/portraits/women/54.jpg", Age = 25, StreetAddress = "309 Arcu. Road",
        City = "Savannah", State = "Georgia", Zip = "56528", Colors = "yellow"
      },
      new Person
      {
        FirstName = "Fleur", LastName = "George", Email = "velit.Quisque.varius@Aliquam.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/55.jpg", Age = 52, StreetAddress = "Ap #349-3590 Lectus Av.",
        City = "Phoenix", State = "Arizona", Zip = "85284", Colors = "blue, indigo, red"
      },
      new Person
      {
        FirstName = "Jacqueline", LastName = "Mathews", Email = "Vivamus.nisi@fringillaporttitorvulputate.net",
        Photo = "https://randomuser.me/api/portraits/women/56.jpg", Age = 65,
        StreetAddress = "P.O. Box 756, 8967 Nunc Street", City = "Helena", State = "MT", Zip = "37598",
        Colors = "violet, red"
      },
      new Person
      {
        FirstName = "Doris", LastName = "Chen", Email = "neque.Nullam@eget.com",
        Photo = "https://randomuser.me/api/portraits/women/57.jpg", Age = 53, StreetAddress = "783-2355 Mauris Avenue",
        City = "Bridgeport", State = "Connecticut", Zip = "12413", Colors = ""
      },
      new Person
      {
        FirstName = "Zorita", LastName = "Sawyer", Email = "sem.vitae.aliquam@aliquetmolestietellus.net",
        Photo = "https://randomuser.me/api/portraits/women/58.jpg", Age = 30,
        StreetAddress = "Ap #628-5643 Vehicula Rd.", City = "Saint Louis", State = "MO", Zip = "99443",
        Colors = "violet, green, indigo, blue"
      },
      new Person
      {
        FirstName = "Holly", LastName = "Burke", Email = "a.auctor@gravidamolestiearcu.org",
        Photo = "https://randomuser.me/api/portraits/women/59.jpg", Age = 39, StreetAddress = "289-8458 Turpis. Rd.",
        City = "Wyoming", State = "Wyoming", Zip = "63299", Colors = "red, blue"
      },
      new Person
      {
        FirstName = "Yvonne", LastName = "Schmidt", Email = "nec.ante@quislectusNullam.org",
        Photo = "https://randomuser.me/api/portraits/women/60.jpg", Age = 37, StreetAddress = "501 Ligula. Street",
        City = "Columbia", State = "MO", Zip = "67798", Colors = "violet, green, yellow, indigo"
      },
      new Person
      {
        FirstName = "Justine", LastName = "Lamb", Email = "aliquam@sitamet.com",
        Photo = "https://randomuser.me/api/portraits/women/61.jpg", Age = 33,
        StreetAddress = "P.O. Box 154, 3737 Etiam Rd.", City = "Tulsa", State = "OK", Zip = "88806", Colors = ""
      },
      new Person
      {
        FirstName = "Amelia", LastName = "Preston", Email = "a.dui.Cras@risusNuncac.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/62.jpg", Age = 61, StreetAddress = "2207 Eu St.",
        City = "Honolulu", State = "Hawaii", Zip = "47434", Colors = ""
      },
      new Person
      {
        FirstName = "Aurora", LastName = "Noble", Email = "sed.facilisis.vitae@estNunc.edu",
        Photo = "https://randomuser.me/api/portraits/women/63.jpg", Age = 48,
        StreetAddress = "P.O. Box 662, 7242 Gravida. Av.", City = "Annapolis", State = "MD", Zip = "27204",
        Colors = ""
      },
      new Person
      {
        FirstName = "Brielle", LastName = "Dunn", Email = "nibh@tellusjustosit.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/64.jpg", Age = 42, StreetAddress = "2484 Non Av.",
        City = "Newark", State = "Delaware", Zip = "99220", Colors = "green"
      },
      new Person
      {
        FirstName = "Casey", LastName = "Deleon", Email = "magnis.dis@semNulla.org",
        Photo = "https://randomuser.me/api/portraits/women/65.jpg", Age = 28,
        StreetAddress = "P.O. Box 121, 862 Pellentesque Street", City = "Gresham", State = "OR", Zip = "29758",
        Colors = "green, blue, red, yellow"
      },
      new Person
      {
        FirstName = "Adara", LastName = "Leach", Email = "consectetuer.adipiscing.elit@ligulaconsectetuer.org",
        Photo = "https://randomuser.me/api/portraits/women/66.jpg", Age = 35,
        StreetAddress = "P.O. Box 132, 7875 Tempus, Street", City = "Chandler", State = "Arizona", Zip = "85348",
        Colors = "red"
      },
      new Person
      {
        FirstName = "Shellie", LastName = "Torres", Email = "ipsum.nunc@dui.net",
        Photo = "https://randomuser.me/api/portraits/women/67.jpg", Age = 29,
        StreetAddress = "P.O. Box 375, 8094 Arcu. Street", City = "St. Petersburg", State = "FL", Zip = "93655",
        Colors = "orange, indigo, red, yellow, blue"
      },
      new Person
      {
        FirstName = "Kalia", LastName = "Solomon", Email = "eros.non.enim@nullaInteger.net",
        Photo = "https://randomuser.me/api/portraits/women/68.jpg", Age = 46, StreetAddress = "992 Nunc Rd.",
        City = "Honolulu", State = "Hawaii", Zip = "41683", Colors = "red, orange, blue, yellow"
      },
      new Person
      {
        FirstName = "Joelle", LastName = "Huff", Email = "Integer@risus.com",
        Photo = "https://randomuser.me/api/portraits/women/69.jpg", Age = 37,
        StreetAddress = "Ap #131-5814 Nulla. Street", City = "St. Petersburg", State = "Florida", Zip = "76049",
        Colors = "indigo, blue, green, orange"
      },
      new Person
      {
        FirstName = "Blair", LastName = "Guy", Email = "placerat.orci@nuncIn.net",
        Photo = "https://randomuser.me/api/portraits/women/70.jpg", Age = 20, StreetAddress = "981-5358 Tempus Street",
        City = "Waterbury", State = "CT", Zip = "38633", Colors = "green, yellow"
      },
      new Person
      {
        FirstName = "Ramona", LastName = "Schmidt", Email = "egestas.rhoncus@dolorsitamet.ca",
        Photo = "https://randomuser.me/api/portraits/women/71.jpg", Age = 35, StreetAddress = "208-7061 Et St.",
        City = "Rock Springs", State = "Wyoming", Zip = "22475", Colors = "green"
      },
      new Person
      {
        FirstName = "Meredith", LastName = "Copeland", Email = "dolor@sedturpis.net",
        Photo = "https://randomuser.me/api/portraits/women/72.jpg", Age = 38, StreetAddress = "5343 Nunc Ave",
        City = "Grand Island", State = "Nebraska", Zip = "94364", Colors = "indigo, blue, yellow, red"
      },
      new Person
      {
        FirstName = "Virginia", LastName = "Hunter", Email = "vitae.aliquet.nec@sem.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/73.jpg", Age = 35, StreetAddress = "469-2858 Fusce St.",
        City = "Clarksville", State = "TN", Zip = "58589", Colors = "red, indigo, violet"
      },
      new Person
      {
        FirstName = "Kirsten", LastName = "Lee", Email = "metus.sit@nullaCraseu.ca",
        Photo = "https://randomuser.me/api/portraits/women/74.jpg", Age = 50,
        StreetAddress = "P.O. Box 211, 6169 Vitae Ave", City = "Frankfort", State = "KY", Zip = "99153",
        Colors = ""
      },
      new Person
      {
        FirstName = "Patricia", LastName = "Daniels", Email = "Duis.ac@Nuncmaurissapien.edu",
        Photo = "https://randomuser.me/api/portraits/women/75.jpg", Age = 38, StreetAddress = "4417 Fringilla, Av.",
        City = "Tacoma", State = "WA", Zip = "86000", Colors = "red, indigo"
      },
      new Person
      {
        FirstName = "Ivana", LastName = "Mckee", Email = "vitae.aliquet@dapibusligulaAliquam.org",
        Photo = "https://randomuser.me/api/portraits/women/76.jpg", Age = 39,
        StreetAddress = "Ap #538-7362 Phasellus Rd.", City = "Columbus", State = "GA", Zip = "91896", Colors = ""
      },
      new Person
      {
        FirstName = "Madison", LastName = "Maxwell", Email = "rutrum@adui.net",
        Photo = "https://randomuser.me/api/portraits/women/77.jpg", Age = 18,
        StreetAddress = "Ap #357-8373 Cursus Avenue", City = "Waterbury", State = "CT", Zip = "20477", Colors = ""
      },
      new Person
      {
        FirstName = "Melodie", LastName = "Hess", Email = "accumsan@duiFuscealiquam.net",
        Photo = "https://randomuser.me/api/portraits/women/78.jpg", Age = 47,
        StreetAddress = "Ap #449-168 Lacinia Road", City = "Springdale", State = "AR", Zip = "72153",
        Colors = "blue, indigo, green"
      },
      new Person
      {
        FirstName = "Rowan", LastName = "Velazquez", Email = "nonummy.Fusce@Proin.ca",
        Photo = "https://randomuser.me/api/portraits/women/79.jpg", Age = 46, StreetAddress = "4552 Ridiculus Rd.",
        City = "New Haven", State = "Connecticut", Zip = "89899", Colors = "red"
      },
      new Person
      {
        FirstName = "Jayme", LastName = "Morales", Email = "lorem.vehicula.et@erosturpis.ca",
        Photo = "https://randomuser.me/api/portraits/women/80.jpg", Age = 34, StreetAddress = "Ap #696-2094 Nibh St.",
        City = "Spokane", State = "Washington", Zip = "16858", Colors = "green, orange"
      },
      new Person
      {
        FirstName = "Tara", LastName = "Sanford", Email = "neque.Morbi@Nullamscelerisqueneque.net",
        Photo = "https://randomuser.me/api/portraits/women/81.jpg", Age = 29,
        StreetAddress = "P.O. Box 588, 596 Penatibus Rd.", City = "Augusta", State = "ME", Zip = "80916",
        Colors = "indigo, violet, blue, green"
      },
      new Person
      {
        FirstName = "Risa", LastName = "Hansen", Email = "tempor@urnasuscipit.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/82.jpg", Age = 47,
        StreetAddress = "P.O. Box 434, 2711 Sem Av.", City = "New Haven", State = "Connecticut", Zip = "94753",
        Colors = "yellow, orange, red, blue, green"
      },
      new Person
      {
        FirstName = "Jamalia", LastName = "Andrews", Email = "Duis@ultricies.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/83.jpg", Age = 34, StreetAddress = "Ap #239-7217 Amet, Rd.",
        City = "Lafayette", State = "LA", Zip = "13307", Colors = "indigo, violet, orange"
      },
      new Person
      {
        FirstName = "Janna", LastName = "Zamora", Email = "ullamcorper.viverra@liberoIntegerin.ca",
        Photo = "https://randomuser.me/api/portraits/women/84.jpg", Age = 29,
        StreetAddress = "P.O. Box 745, 8289 Tempor St.", City = "Montpelier", State = "Vermont", Zip = "91981",
        Colors = "orange"
      },
      new Person
      {
        FirstName = "McKenzie", LastName = "Potts", Email = "nec.quam@Curabiturmassa.edu",
        Photo = "https://randomuser.me/api/portraits/women/85.jpg", Age = 28, StreetAddress = "943 Aliquam Road",
        City = "Jacksonville", State = "Florida", Zip = "25858", Colors = "yellow, green"
      },
      new Person
      {
        FirstName = "Maxine", LastName = "Flores", Email = "magnis@egetipsum.edu",
        Photo = "https://randomuser.me/api/portraits/women/86.jpg", Age = 36,
        StreetAddress = "P.O. Box 592, 2713 Feugiat Avenue", City = "Sacrawomen", State = "California", Zip = "90247",
        Colors = "blue, violet, orange"
      },
      new Person
      {
        FirstName = "Deirdre", LastName = "Salinas", Email = "lacus@loremDonec.edu",
        Photo = "https://randomuser.me/api/portraits/women/87.jpg", Age = 23, StreetAddress = "Ap #380-1443 Nunc Road",
        City = "Kaneohe", State = "Hawaii", Zip = "36679", Colors = "green, red, orange, yellow, blue"
      },
      new Person
      {
        FirstName = "Kimberly", LastName = "Page", Email = "rutrum.non@consectetuereuismodest.ca",
        Photo = "https://randomuser.me/api/portraits/women/88.jpg", Age = 58, StreetAddress = "2902 Massa. St.",
        City = "Kearney", State = "NE", Zip = "18534", Colors = "green"
      },
      new Person
      {
        FirstName = "Delilah", LastName = "Branch", Email = "pretium@tellus.com",
        Photo = "https://randomuser.me/api/portraits/women/89.jpg", Age = 47, StreetAddress = "7630 Semper Street",
        City = "New Haven", State = "Connecticut", Zip = "65475", Colors = "violet, green"
      },
      new Person
      {
        FirstName = "Clare", LastName = "Tillman", Email = "nulla.Integer@liberoProinmi.edu",
        Photo = "https://randomuser.me/api/portraits/women/90.jpg", Age = 39,
        StreetAddress = "P.O. Box 362, 4609 Dignissim Rd.", City = "Columbus", State = "Georgia", Zip = "77885",
        Colors = "violet, red, orange, yellow, green"
      },
      new Person
      {
        FirstName = "Kaitlin", LastName = "Little", Email = "Proin.vel@rutrumnonhendrerit.edu",
        Photo = "https://randomuser.me/api/portraits/women/91.jpg", Age = 53, StreetAddress = "310-3588 Sem Rd.",
        City = "Fort Wayne", State = "Indiana", Zip = "15075", Colors = "blue, yellow, violet, green"
      },
      new Person
      {
        FirstName = "Charissa", LastName = "Frost", Email = "ligula@velit.edu",
        Photo = "https://randomuser.me/api/portraits/women/92.jpg", Age = 29, StreetAddress = "470-9884 Non, St.",
        City = "Hattiesburg", State = "MS", Zip = "83652", Colors = "yellow"
      },
      new Person
      {
        FirstName = "Dora", LastName = "Sweeney", Email = "a.dui@aceleifendvitae.ca",
        Photo = "https://randomuser.me/api/portraits/women/93.jpg", Age = 60, StreetAddress = "Ap #479-5319 Est Av.",
        City = "Bloomington", State = "Minnesota", Zip = "79416", Colors = "blue, orange, indigo, yellow, green"
      },
      new Person
      {
        FirstName = "Elaine", LastName = "Rogers", Email = "Donec@Quisqueaclibero.co.uk",
        Photo = "https://randomuser.me/api/portraits/women/94.jpg", Age = 60, StreetAddress = "9360 Eu Ave",
        City = "Atlanta", State = "Georgia", Zip = "24698", Colors = "indigo, violet, red, green, blue"
      },
      new Person
      {
        FirstName = "Kiayada", LastName = "Munoz", Email = "mattis.semper@seddolor.com",
        Photo = "https://randomuser.me/api/portraits/women/95.jpg", Age = 42,
        StreetAddress = "P.O. Box 355, 1027 Morbi St.", City = "Boise", State = "ID", Zip = "98406",
        Colors = "orange, yellow, violet, green"
      },
      new Person
      {
        FirstName = "Kiona", LastName = "Tate", Email = "nunc.sed.pede@enim.ca",
        Photo = "https://randomuser.me/api/portraits/women/96.jpg", Age = 40,
        StreetAddress = "P.O. Box 573, 1607 Libero Avenue", City = "Grand Island", State = "Nebraska", Zip = "49088",
        Colors = "blue, violet"
      },
      new Person
      {
        FirstName = "Reagan", LastName = "Greer", Email = "Curabitur.massa.Vestibulum@sapien.com",
        Photo = "https://randomuser.me/api/portraits/women/97.jpg", Age = 51, StreetAddress = "717-2829 Accumsan Road",
        City = "San Antonio", State = "TX", Zip = "88521", Colors = "green, blue"
      },
      new Person
      {
        FirstName = "Florence", LastName = "Santana", Email = "neque.venenatis@dignissim.com",
        Photo = "https://randomuser.me/api/portraits/women/98.jpg", Age = 37, StreetAddress = "334-4284 Gravida Street",
        City = "San Jose", State = "California", Zip = "92410", Colors = "yellow, red"
      },
      new Person
      {
        FirstName = "Wilma", LastName = "Frank", Email = "nec.urna.suscipit@incursuset.com",
        Photo = "https://randomuser.me/api/portraits/women/99.jpg", Age = 63, StreetAddress = "866-2075 Placerat Rd.",
        City = "Mobile", State = "Alabama", Zip = "36700", Colors = "yellow"
      },
      new Person
      {
        FirstName = "Adrian", LastName = "Roth", Email = "magna.Phasellus@auctornonfeugiat.ca",
        Photo = "https://randomuser.me/api/portraits/men/0.jpg", Age = 26, StreetAddress = "3654 Odio Street",
        City = "Little Rock", State = "AR", Zip = "71099", Colors = ""
      },
      new Person
      {
        FirstName = "Knox", LastName = "Dudley", Email = "adipiscing.non.luctus@Quisqueporttitoreros.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/1.jpg", Age = 60,
        StreetAddress = "719-7448 Scelerisque Street", City = "Norfolk", State = "VA", Zip = "28010",
        Colors = "red, orange, blue, green"
      },
      new Person
      {
        FirstName = "Malik", LastName = "Tanner", Email = "eget.venenatis.a@imperdieterat.edu",
        Photo = "https://randomuser.me/api/portraits/men/2.jpg", Age = 53, StreetAddress = "697-2214 Ultricies Road",
        City = "Annapolis", State = "MD", Zip = "45289", Colors = "indigo, blue, green, red, violet"
      },
      new Person
      {
        FirstName = "Dominic", LastName = "Whitley", Email = "egestas.Duis.ac@hymenaeos.edu",
        Photo = "https://randomuser.me/api/portraits/men/3.jpg", Age = 44, StreetAddress = "932-2651 Vel Rd.",
        City = "Wilmington", State = "Delaware", Zip = "36407", Colors = "yellow, indigo, orange"
      },
      new Person
      {
        FirstName = "Gannon", LastName = "Suarez", Email = "diam.eu.dolor@iaculislacuspede.org",
        Photo = "https://randomuser.me/api/portraits/men/4.jpg", Age = 49, StreetAddress = "257-9402 Vel Rd.",
        City = "Mesa", State = "AZ", Zip = "85373", Colors = "yellow, red"
      },
      new Person
      {
        FirstName = "Gareth", LastName = "Kirk", Email = "consectetuer.adipiscing@arcuacorci.com",
        Photo = "https://randomuser.me/api/portraits/men/5.jpg", Age = 64, StreetAddress = "7200 Vulputate, Street",
        City = "Racine", State = "WI", Zip = "94830", Colors = "violet, red, blue"
      },
      new Person
      {
        FirstName = "Russell", LastName = "Hood", Email = "orci@Praesenteudui.org",
        Photo = "https://randomuser.me/api/portraits/men/6.jpg", Age = 28, StreetAddress = "Ap #938-1740 Et, Av.",
        City = "Meridian", State = "ID", Zip = "86820", Colors = ""
      },
      new Person
      {
        FirstName = "Len", LastName = "Kerr", Email = "vel@blanditat.com",
        Photo = "https://randomuser.me/api/portraits/men/7.jpg", Age = 64, StreetAddress = "Ap #983-4765 Neque Road",
        City = "Jefferson City", State = "Missouri", Zip = "54276", Colors = "red, indigo"
      },
      new Person
      {
        FirstName = "Alfonso", LastName = "Oneal", Email = "Cum@Nullatemporaugue.edu",
        Photo = "https://randomuser.me/api/portraits/men/8.jpg", Age = 34, StreetAddress = "4730 Non St.",
        City = "Pocatello", State = "ID", Zip = "36448", Colors = ""
      },
      new Person
      {
        FirstName = "Carter", LastName = "Wong", Email = "Pellentesque.tincidunt.tempus@adipiscing.com",
        Photo = "https://randomuser.me/api/portraits/men/9.jpg", Age = 36, StreetAddress = "911-7723 Metus. Road",
        City = "Lowell", State = "Massachusetts", Zip = "19224", Colors = "red, orange, indigo, green, violet"
      },
      new Person
      {
        FirstName = "Omar", LastName = "Stein", Email = "velit@consequat.net",
        Photo = "https://randomuser.me/api/portraits/men/10.jpg", Age = 49, StreetAddress = "2538 Interdum. St.",
        City = "South Portland", State = "ME", Zip = "68643", Colors = "indigo, red, orange"
      },
      new Person
      {
        FirstName = "Amos", LastName = "Byrd", Email = "lectus.pede@idmagna.ca",
        Photo = "https://randomuser.me/api/portraits/men/11.jpg", Age = 38, StreetAddress = "1583 Dolor Avenue",
        City = "Mesa", State = "AZ", Zip = "86065", Colors = "yellow, indigo, blue, violet, red"
      },
      new Person
      {
        FirstName = "Jarrod", LastName = "Manning", Email = "convallis.convallis.dolor@adipiscingelitAliquam.edu",
        Photo = "https://randomuser.me/api/portraits/men/12.jpg", Age = 65,
        StreetAddress = "P.O. Box 564, 3797 Sodales Road", City = "Boston", State = "Massachusetts", Zip = "69314",
        Colors = "violet"
      },
      new Person
      {
        FirstName = "Solomon", LastName = "Atkins", Email = "eu.metus.In@eratvolutpatNulla.net",
        Photo = "https://randomuser.me/api/portraits/men/13.jpg", Age = 35, StreetAddress = "Ap #389-7537 Morbi Rd.",
        City = "Shreveport", State = "Louisiana", Zip = "68472", Colors = "violet"
      },
      new Person
      {
        FirstName = "Davis", LastName = "Medina", Email = "ultrices.iaculis.odio@facilisis.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/14.jpg", Age = 46, StreetAddress = "Ap #390-5678 Enim. Av.",
        City = "Omaha", State = "NE", Zip = "28550", Colors = "green"
      },
      new Person
      {
        FirstName = "Jerome", LastName = "Pope", Email = "Curae.Phasellus@commodohendreritDonec.ca",
        Photo = "https://randomuser.me/api/portraits/men/15.jpg", Age = 20, StreetAddress = "5726 Amet Rd.",
        City = "Seattle", State = "Washington", Zip = "56538", Colors = "violet, green, red, indigo"
      },
      new Person
      {
        FirstName = "Carson", LastName = "Henson", Email = "Phasellus.elit.pede@etpedeNunc.org",
        Photo = "https://randomuser.me/api/portraits/men/16.jpg", Age = 59, StreetAddress = "725-1099 Amet, Rd.",
        City = "Aurora", State = "Colorado", Zip = "44936", Colors = "blue, green, indigo"
      },
      new Person
      {
        FirstName = "Dane", LastName = "Snider", Email = "Nullam.vitae@nullaIntegerurna.com",
        Photo = "https://randomuser.me/api/portraits/men/17.jpg", Age = 42,
        StreetAddress = "P.O. Box 238, 5129 Nullam Ave", City = "Athens", State = "Georgia", Zip = "37004",
        Colors = "yellow, orange, blue"
      },
      new Person
      {
        FirstName = "Jasper", LastName = "Grimes", Email = "ligula.Aliquam.erat@ullamcorperDuisat.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/18.jpg", Age = 29,
        StreetAddress = "Ap #510-505 Cursus Avenue", City = "Honolulu", State = "Hawaii", Zip = "81832",
        Colors = "blue"
      },
      new Person
      {
        FirstName = "Jacob", LastName = "Lang", Email = "a.auctor@nibhPhasellus.com",
        Photo = "https://randomuser.me/api/portraits/men/19.jpg", Age = 42,
        StreetAddress = "Ap #888-8081 Facilisis, Street", City = "Olympia", State = "WA", Zip = "20292",
        Colors = "orange, red"
      },
      new Person
      {
        FirstName = "Hayden", LastName = "Drake", Email = "nulla.Integer.vulputate@sagittislobortismauris.ca",
        Photo = "https://randomuser.me/api/portraits/men/20.jpg", Age = 43, StreetAddress = "896-4338 Massa. Rd.",
        City = "Gary", State = "Indiana", Zip = "63682", Colors = "yellow, indigo, orange, red, blue"
      },
      new Person
      {
        FirstName = "Geoffrey", LastName = "Reid", Email = "lorem.ipsum.sodales@risusDonec.net",
        Photo = "https://randomuser.me/api/portraits/men/21.jpg", Age = 40, StreetAddress = "194-2658 Amet, Street",
        City = "Jonesboro", State = "AR", Zip = "71201", Colors = ""
      },
      new Person
      {
        FirstName = "Buckminster", LastName = "Newman", Email = "vitae.erat.vel@Integermollis.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/22.jpg", Age = 30, StreetAddress = "2951 Id Rd.",
        City = "Idaho Falls", State = "Idaho", Zip = "26371", Colors = "yellow, green"
      },
      new Person
      {
        FirstName = "Ulric", LastName = "Valdez", Email = "quam@Vivamus.edu",
        Photo = "https://randomuser.me/api/portraits/men/23.jpg", Age = 49,
        StreetAddress = "P.O. Box 409, 1951 Porttitor St.", City = "Owensboro", State = "Kentucky", Zip = "41239",
        Colors = "violet, red"
      },
      new Person
      {
        FirstName = "Hamish", LastName = "Mcclain", Email = "Donec@Phasellusin.edu",
        Photo = "https://randomuser.me/api/portraits/men/24.jpg", Age = 29, StreetAddress = "8819 Ante. St.",
        City = "Chandler", State = "AZ", Zip = "85818", Colors = "orange, violet, red"
      },
      new Person
      {
        FirstName = "Lance", LastName = "Farley", Email = "magna.Sed.eu@semmagna.org",
        Photo = "https://randomuser.me/api/portraits/men/25.jpg", Age = 35, StreetAddress = "191 Ridiculus Rd.",
        City = "Casper", State = "WY", Zip = "27284", Colors = "yellow, violet, red, orange"
      },
      new Person
      {
        FirstName = "Christian", LastName = "Tyson", Email = "facilisis.magna@cursus.edu",
        Photo = "https://randomuser.me/api/portraits/men/26.jpg", Age = 54,
        StreetAddress = "P.O. Box 611, 1917 Pede. Avenue", City = "Essex", State = "Vermont", Zip = "23561",
        Colors = "red, green"
      },
      new Person
      {
        FirstName = "Sawyer", LastName = "Henry", Email = "nec.tempus@malesuadavel.net",
        Photo = "https://randomuser.me/api/portraits/men/27.jpg", Age = 62, StreetAddress = "Ap #124-2753 Vitae St.",
        City = "Aurora", State = "IL", Zip = "14804", Colors = "orange, green, indigo"
      },
      new Person
      {
        FirstName = "Brennan", LastName = "Shelton", Email = "cursus@augueid.net",
        Photo = "https://randomuser.me/api/portraits/men/28.jpg", Age = 45, StreetAddress = "797-6294 Sit Road",
        City = "Rockford", State = "IL", Zip = "25180", Colors = "orange"
      },
      new Person
      {
        FirstName = "Quinlan", LastName = "Kramer", Email = "nec.leo@semperauctorMauris.com",
        Photo = "https://randomuser.me/api/portraits/men/29.jpg", Age = 33, StreetAddress = "184-3557 A Road",
        City = "Kansas City", State = "Kansas", Zip = "20955", Colors = "indigo"
      },
      new Person
      {
        FirstName = "Neville", LastName = "Buckner", Email = "non@egestasnuncsed.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/30.jpg", Age = 21,
        StreetAddress = "Ap #480-8771 Maecenas Avenue", City = "Butte", State = "MT", Zip = "92186", Colors = ""
      },
      new Person
      {
        FirstName = "Dexter", LastName = "Case", Email = "Sed.nulla@at.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/31.jpg", Age = 42, StreetAddress = "473-4360 Facilisis Rd.",
        City = "Bloomington", State = "MN", Zip = "29981", Colors = "green, red, orange"
      },
      new Person
      {
        FirstName = "Quinn", LastName = "Weber", Email = "amet@enimSuspendisse.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/32.jpg", Age = 20, StreetAddress = "770 Nec St.",
        City = "Fort Collins", State = "Colorado", Zip = "13157", Colors = "red, violet"
      },
      new Person
      {
        FirstName = "Jerome", LastName = "Grimes", Email = "consectetuer.ipsum@Nam.edu",
        Photo = "https://randomuser.me/api/portraits/men/33.jpg", Age = 31,
        StreetAddress = "P.O. Box 772, 7156 Velit. St.", City = "Oklahoma City", State = "Oklahoma", Zip = "20145",
        Colors = "orange, yellow, green, blue"
      },
      new Person
      {
        FirstName = "Cedric", LastName = "Park", Email = "malesuada.malesuada@vitae.edu",
        Photo = "https://randomuser.me/api/portraits/men/34.jpg", Age = 42, StreetAddress = "5895 Mauris Av.",
        City = "Montgomery", State = "AL", Zip = "36539", Colors = "orange, blue, green, indigo, red"
      },
      new Person
      {
        FirstName = "Gregory", LastName = "Kent", Email = "commodo@tellusNunclectus.com",
        Photo = "https://randomuser.me/api/portraits/men/35.jpg", Age = 43,
        StreetAddress = "P.O. Box 803, 5984 Ultrices. Ave", City = "North Las Vegas", State = "NV", Zip = "50084",
        Colors = "green, orange, indigo"
      },
      new Person
      {
        FirstName = "Ross", LastName = "Berger", Email = "sem.mollis.dui@aultriciesadipiscing.com",
        Photo = "https://randomuser.me/api/portraits/men/36.jpg", Age = 19, StreetAddress = "308-6125 Erat St.",
        City = "Shreveport", State = "LA", Zip = "69223", Colors = "red, indigo"
      },
      new Person
      {
        FirstName = "Lester", LastName = "Mcfadden", Email = "tempor.arcu@diamdictumsapien.com",
        Photo = "https://randomuser.me/api/portraits/men/37.jpg", Age = 34,
        StreetAddress = "P.O. Box 742, 4083 Ornare Street", City = "Springfield", State = "MA", Zip = "37085",
        Colors = "red, violet, orange, yellow"
      },
      new Person
      {
        FirstName = "Timothy", LastName = "Woods", Email = "dolor.Fusce.feugiat@lectus.net",
        Photo = "https://randomuser.me/api/portraits/men/38.jpg", Age = 35,
        StreetAddress = "P.O. Box 698, 9482 Orci Road", City = "Salt Lake City", State = "UT", Zip = "60403",
        Colors = "violet"
      },
      new Person
      {
        FirstName = "Dieter", LastName = "Guthrie", Email = "in.faucibus@eunullaat.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/39.jpg", Age = 63, StreetAddress = "Ap #171-1950 Velit. Av.",
        City = "San Francisco", State = "CA", Zip = "95194", Colors = "violet, yellow, orange, red, green"
      },
      new Person
      {
        FirstName = "Oren", LastName = "Cochran", Email = "sem.Nulla.interdum@consectetueradipiscingelit.net",
        Photo = "https://randomuser.me/api/portraits/men/40.jpg", Age = 62, StreetAddress = "Ap #164-471 Purus. Ave",
        City = "Knoxville", State = "TN", Zip = "91685", Colors = "blue, green, violet, orange"
      },
      new Person
      {
        FirstName = "Herrod", LastName = "Cohen", Email = "lectus@faucibus.net",
        Photo = "https://randomuser.me/api/portraits/men/41.jpg", Age = 38, StreetAddress = "Ap #817-9957 Felis Av.",
        City = "Fairbanks", State = "Alaska", Zip = "99596", Colors = "red, green, yellow, violet"
      },
      new Person
      {
        FirstName = "Gavin", LastName = "Baker", Email = "Cum@gravidaAliquam.ca",
        Photo = "https://randomuser.me/api/portraits/men/42.jpg", Age = 49, StreetAddress = "5411 Pede, Road",
        City = "Bloomington", State = "Minnesota", Zip = "61624", Colors = "orange"
      },
      new Person
      {
        FirstName = "Graham", LastName = "Charles", Email = "Donec.est@Nuncsedorci.ca",
        Photo = "https://randomuser.me/api/portraits/men/43.jpg", Age = 27, StreetAddress = "Ap #275-9094 Orci Road",
        City = "Lawton", State = "OK", Zip = "71172", Colors = "indigo"
      },
      new Person
      {
        FirstName = "Fuller", LastName = "Bryant", Email = "auctor@mauris.com",
        Photo = "https://randomuser.me/api/portraits/men/44.jpg", Age = 33,
        StreetAddress = "P.O. Box 336, 8138 Condimentum. Ave", City = "Aurora", State = "CO", Zip = "96657",
        Colors = ""
      },
      new Person
      {
        FirstName = "Dalton", LastName = "Meyers", Email = "dis.parturient.montes@nibh.org",
        Photo = "https://randomuser.me/api/portraits/men/45.jpg", Age = 58, StreetAddress = "6012 Eu, St.",
        City = "Lewiston", State = "ME", Zip = "23047", Colors = ""
      },
      new Person
      {
        FirstName = "Kasimir", LastName = "York", Email = "non.cursus@ligulaNullamfeugiat.ca",
        Photo = "https://randomuser.me/api/portraits/men/46.jpg", Age = 30, StreetAddress = "Ap #256-8504 Erat. Av.",
        City = "Sioux City", State = "Iowa", Zip = "67294", Colors = "red, blue"
      },
      new Person
      {
        FirstName = "Prescott", LastName = "Stevens", Email = "magna@eget.com",
        Photo = "https://randomuser.me/api/portraits/men/47.jpg", Age = 42,
        StreetAddress = "727-5049 Phasellus Avenue", City = "Lexington", State = "KY", Zip = "48141",
        Colors = "violet, orange, yellow, green, red"
      },
      new Person
      {
        FirstName = "Grady", LastName = "Sloan", Email = "pharetra@NullamenimSed.net",
        Photo = "https://randomuser.me/api/portraits/men/48.jpg", Age = 37, StreetAddress = "428-9600 Est. Street",
        City = "St. Petersburg", State = "Florida", Zip = "93012", Colors = "red, orange, green, violet, blue"
      },
      new Person
      {
        FirstName = "Nissim", LastName = "Lopez", Email = "mi.ac@hendrerit.edu",
        Photo = "https://randomuser.me/api/portraits/men/49.jpg", Age = 19, StreetAddress = "Ap #443-9944 Netus Road",
        City = "Hattiesburg", State = "Mississippi", Zip = "40567", Colors = "orange, blue"
      },
      new Person
      {
        FirstName = "Fletcher", LastName = "Herrera", Email = "et.malesuada.fames@augueeu.edu",
        Photo = "https://randomuser.me/api/portraits/men/50.jpg", Age = 58,
        StreetAddress = "P.O. Box 495, 3003 Nulla Street", City = "Phoenix", State = "AZ", Zip = "85252",
        Colors = ""
      },
      new Person
      {
        FirstName = "Bruce", LastName = "Reynolds", Email = "vestibulum.massa.rutrum@nislsemconsequat.ca",
        Photo = "https://randomuser.me/api/portraits/men/51.jpg", Age = 55, StreetAddress = "2694 A Av.",
        City = "Lakewood", State = "Colorado", Zip = "14782", Colors = ""
      },
      new Person
      {
        FirstName = "Nero", LastName = "Marks", Email = "dictum@dignissimmagna.edu",
        Photo = "https://randomuser.me/api/portraits/men/52.jpg", Age = 61,
        StreetAddress = "P.O. Box 742, 6492 Dis Road", City = "Colorado Springs", State = "Colorado", Zip = "78945",
        Colors = ""
      },
      new Person
      {
        FirstName = "Xenos", LastName = "Dunn", Email = "sit.amet.consectetuer@Nullainterdum.org",
        Photo = "https://randomuser.me/api/portraits/men/53.jpg", Age = 33, StreetAddress = "Ap #877-792 Vitae Ave",
        City = "Bellevue", State = "WA", Zip = "49438", Colors = "indigo, orange, blue"
      },
      new Person
      {
        FirstName = "Keefe", LastName = "Melton", Email = "vitae.sodales@dolor.com",
        Photo = "https://randomuser.me/api/portraits/men/54.jpg", Age = 47, StreetAddress = "785-3198 Dictum Avenue",
        City = "North Las Vegas", State = "Nevada", Zip = "79315", Colors = "blue, yellow, red, orange, green"
      },
      new Person
      {
        FirstName = "Nicholas", LastName = "Dorsey", Email = "amet.ultricies.sem@ipsum.com",
        Photo = "https://randomuser.me/api/portraits/men/55.jpg", Age = 46, StreetAddress = "1574 Ut, Street",
        City = "Hillsboro", State = "Oregon", Zip = "61151", Colors = "yellow, orange, violet, green, indigo"
      },
      new Person
      {
        FirstName = "Prescott", LastName = "Contreras", Email = "tincidunt.pede@erosProin.edu",
        Photo = "https://randomuser.me/api/portraits/men/56.jpg", Age = 46, StreetAddress = "Ap #670-109 Sit Ave",
        City = "Bridgeport", State = "Connecticut", Zip = "55754", Colors = "violet, red, blue, orange"
      },
      new Person
      {
        FirstName = "Luke", LastName = "Jones", Email = "lectus.Nullam.suscipit@Morbinon.ca",
        Photo = "https://randomuser.me/api/portraits/men/57.jpg", Age = 21, StreetAddress = "825-8601 Ipsum Road",
        City = "Austin", State = "TX", Zip = "40411", Colors = "yellow, blue"
      },
      new Person
      {
        FirstName = "Reed", LastName = "Lyons", Email = "pulvinar.arcu.et@in.net",
        Photo = "https://randomuser.me/api/portraits/men/58.jpg", Age = 39, StreetAddress = "7194 Duis Street",
        City = "Billings", State = "MT", Zip = "65474", Colors = ""
      },
      new Person
      {
        FirstName = "Palmer", LastName = "Weber", Email = "sem@gravidamolestie.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/59.jpg", Age = 57,
        StreetAddress = "Ap #472-7367 Natoque Rd.", City = "Naperville", State = "Illinois", Zip = "84594",
        Colors = "indigo, orange, green, red, blue"
      },
      new Person
      {
        FirstName = "Octavius", LastName = "Neal", Email = "amet.luctus@nibhvulputatemauris.com",
        Photo = "https://randomuser.me/api/portraits/men/60.jpg", Age = 47, StreetAddress = "289-4045 Convallis Rd.",
        City = "Green Bay", State = "Wisconsin", Zip = "31018", Colors = "indigo, green, violet, yellow, red"
      },
      new Person
      {
        FirstName = "Ulric", LastName = "Mcclain", Email = "lorem@necanteblandit.net",
        Photo = "https://randomuser.me/api/portraits/men/61.jpg", Age = 61,
        StreetAddress = "Ap #256-7714 Fermentum Street", City = "Biloxi", State = "MS", Zip = "86301",
        Colors = "yellow"
      },
      new Person
      {
        FirstName = "Dante", LastName = "Meyers", Email = "Pellentesque.habitant.morbi@tinciduntorciquis.edu",
        Photo = "https://randomuser.me/api/portraits/men/62.jpg", Age = 43, StreetAddress = "Ap #292-3833 Nisi Road",
        City = "Fresno", State = "California", Zip = "93524", Colors = "indigo, orange, green"
      },
      new Person
      {
        FirstName = "Christian", LastName = "Goodwin", Email = "magna@euplacerat.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/63.jpg", Age = 18,
        StreetAddress = "Ap #260-3463 Aenean Street", City = "North Las Vegas", State = "Nevada", Zip = "18054",
        Colors = "yellow, blue, violet, orange"
      },
      new Person
      {
        FirstName = "Dalton", LastName = "Knapp", Email = "lacus.Mauris@nuncnullavulputate.org",
        Photo = "https://randomuser.me/api/portraits/men/64.jpg", Age = 48, StreetAddress = "Ap #439-8201 Orci, St.",
        City = "Lakewood", State = "Colorado", Zip = "29737", Colors = "blue, red, violet"
      },
      new Person
      {
        FirstName = "Emery", LastName = "Ramos", Email = "amet@Quisque.net",
        Photo = "https://randomuser.me/api/portraits/men/65.jpg", Age = 56, StreetAddress = "553-2890 Metus. Rd.",
        City = "Baton Rouge", State = "LA", Zip = "63007", Colors = "green, blue, red, orange, indigo"
      },
      new Person
      {
        FirstName = "Zachary", LastName = "Wilkinson", Email = "montes.nascetur@nunc.edu",
        Photo = "https://randomuser.me/api/portraits/men/66.jpg", Age = 53,
        StreetAddress = "P.O. Box 618, 5235 Volutpat. Ave", City = "Fresno", State = "California", Zip = "93810",
        Colors = ""
      },
      new Person
      {
        FirstName = "Marshall", LastName = "Powell", Email = "augue@nonummyFusce.com",
        Photo = "https://randomuser.me/api/portraits/men/67.jpg", Age = 49, StreetAddress = "796-3689 At Street",
        City = "Lakewood", State = "Colorado", Zip = "32173", Colors = ""
      },
      new Person
      {
        FirstName = "Hasad", LastName = "Bauer", Email = "facilisis.magna@necurnaet.com",
        Photo = "https://randomuser.me/api/portraits/men/68.jpg", Age = 23, StreetAddress = "1939 Porttitor Rd.",
        City = "Lakewood", State = "Colorado", Zip = "18626", Colors = "blue, indigo, red, violet"
      },
      new Person
      {
        FirstName = "Brandon", LastName = "Bolton", Email = "nisl.arcu@semPellentesqueut.edu",
        Photo = "https://randomuser.me/api/portraits/men/69.jpg", Age = 54, StreetAddress = "5195 Odio, Road",
        City = "Waterbury", State = "Connecticut", Zip = "89239", Colors = "green, blue, indigo, orange, red"
      },
      new Person
      {
        FirstName = "Louis", LastName = "Garza", Email = "magna.et@tempusmauris.com",
        Photo = "https://randomuser.me/api/portraits/men/70.jpg", Age = 29, StreetAddress = "5252 Adipiscing, Ave",
        City = "Jackson", State = "Mississippi", Zip = "68310", Colors = "yellow, blue, orange"
      },
      new Person
      {
        FirstName = "Cullen", LastName = "Cotton", Email = "facilisis.Suspendisse.commodo@ProinmiAliquam.org",
        Photo = "https://randomuser.me/api/portraits/men/71.jpg", Age = 61, StreetAddress = "7444 Amet, Street",
        City = "Glendale", State = "Arizona", Zip = "85712", Colors = "orange, violet"
      },
      new Person
      {
        FirstName = "Cedric", LastName = "Avila", Email = "dui@orciluctus.com",
        Photo = "https://randomuser.me/api/portraits/men/72.jpg", Age = 53, StreetAddress = "Ap #718-9089 Ante Rd.",
        City = "Huntsville", State = "AL", Zip = "35117", Colors = "blue, red, green, orange"
      },
      new Person
      {
        FirstName = "Colby", LastName = "Allison", Email = "eu@gravidaAliquam.org",
        Photo = "https://randomuser.me/api/portraits/men/73.jpg", Age = 29, StreetAddress = "Ap #964-3837 Est St.",
        City = "Jefferson City", State = "Missouri", Zip = "64614", Colors = ""
      },
      new Person
      {
        FirstName = "Stuart", LastName = "Bond", Email = "et@mattisvelitjusto.ca",
        Photo = "https://randomuser.me/api/portraits/men/74.jpg", Age = 26, StreetAddress = "184 Amet Avenue",
        City = "Knoxville", State = "Tennessee", Zip = "33621", Colors = "indigo"
      },
      new Person
      {
        FirstName = "Yoshio", LastName = "Sherman", Email = "nunc@amet.org",
        Photo = "https://randomuser.me/api/portraits/men/75.jpg", Age = 45, StreetAddress = "5781 Lectus. Rd.",
        City = "Lewiston", State = "ME", Zip = "77924", Colors = "indigo, orange"
      },
      new Person
      {
        FirstName = "Drake", LastName = "Cherry", Email = "in.hendrerit@sapiencursusin.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/76.jpg", Age = 64, StreetAddress = "475 Eu Rd.",
        City = "Hartford", State = "Connecticut", Zip = "85238", Colors = "blue, violet, orange, yellow, green"
      },
      new Person
      {
        FirstName = "Louis", LastName = "Holder", Email = "nec.imperdiet.nec@sodalesatvelit.com",
        Photo = "https://randomuser.me/api/portraits/men/77.jpg", Age = 38,
        StreetAddress = "668-338 Suspendisse Road", City = "Newark", State = "DE", Zip = "65805", Colors = "yellow"
      },
      new Person
      {
        FirstName = "Graiden", LastName = "Wright", Email = "mauris.eu.elit@parturientmontes.net",
        Photo = "https://randomuser.me/api/portraits/men/78.jpg", Age = 54, StreetAddress = "2994 Interdum Road",
        City = "Kapolei", State = "Hawaii", Zip = "41090", Colors = "blue, yellow, orange"
      },
      new Person
      {
        FirstName = "Colby", LastName = "Fleming", Email = "vehicula.aliquet.libero@sempererat.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/79.jpg", Age = 55, StreetAddress = "8242 Non Rd.",
        City = "Dover", State = "DE", Zip = "13343", Colors = "blue, red, yellow, indigo, orange"
      },
      new Person
      {
        FirstName = "Rooney", LastName = "Wood", Email = "Vestibulum.accumsan@justoeu.edu",
        Photo = "https://randomuser.me/api/portraits/men/80.jpg", Age = 21,
        StreetAddress = "Ap #365-8537 Phasellus Road", City = "Little Rock", State = "Arkansas", Zip = "72020",
        Colors = "yellow"
      },
      new Person
      {
        FirstName = "Jason", LastName = "Barker", Email = "vulputate.ullamcorper.magna@auctorMaurisvel.org",
        Photo = "https://randomuser.me/api/portraits/men/81.jpg", Age = 25, StreetAddress = "623-2109 Vulputate, Rd.",
        City = "Lowell", State = "Massachusetts", Zip = "57157", Colors = ""
      },
      new Person
      {
        FirstName = "Boris", LastName = "Stevenson", Email = "egestas.lacinia@Quisquepurus.net",
        Photo = "https://randomuser.me/api/portraits/men/82.jpg", Age = 40, StreetAddress = "2919 Sit Av.",
        City = "Rockford", State = "IL", Zip = "87130", Colors = "green"
      },
      new Person
      {
        FirstName = "August", LastName = "Cline", Email = "adipiscing@rutrumlorem.org",
        Photo = "https://randomuser.me/api/portraits/men/83.jpg", Age = 21,
        StreetAddress = "Ap #173-8902 Dictum Street", City = "Naperville", State = "IL", Zip = "16732",
        Colors = "violet"
      },
      new Person
      {
        FirstName = "Octavius", LastName = "Herrera", Email = "mattis.Integer.eu@habitantmorbitristique.com",
        Photo = "https://randomuser.me/api/portraits/men/84.jpg", Age = 48,
        StreetAddress = "Ap #263-5265 Laoreet Avenue", City = "Topeka", State = "KS", Zip = "66420", Colors = ""
      },
      new Person
      {
        FirstName = "Felix", LastName = "Allen", Email = "eu.dui@elitpharetraut.com",
        Photo = "https://randomuser.me/api/portraits/men/85.jpg", Age = 43, StreetAddress = "1034 Consectetuer Road",
        City = "Pittsburgh", State = "PA", Zip = "58752", Colors = "blue, red, orange"
      },
      new Person
      {
        FirstName = "Graham", LastName = "Mccarty", Email = "tempor.diam@nulla.com",
        Photo = "https://randomuser.me/api/portraits/men/86.jpg", Age = 61,
        StreetAddress = "P.O. Box 583, 2856 Vivamus Ave", City = "Kaneohe", State = "Hawaii", Zip = "61370",
        Colors = "yellow"
      },
      new Person
      {
        FirstName = "Dante", LastName = "Kidd", Email = "dolor@luctusvulputate.net",
        Photo = "https://randomuser.me/api/portraits/men/87.jpg", Age = 21, StreetAddress = "767-3922 Semper Street",
        City = "Nashville", State = "Tennessee", Zip = "91327", Colors = "yellow, violet, green, orange"
      },
      new Person
      {
        FirstName = "Eaton", LastName = "Sherman", Email = "feugiat.tellus@adipiscing.net",
        Photo = "https://randomuser.me/api/portraits/men/88.jpg", Age = 33, StreetAddress = "7071 Euismod Avenue",
        City = "Rockford", State = "IL", Zip = "18863", Colors = "red, blue"
      },
      new Person
      {
        FirstName = "Gil", LastName = "Stokes", Email = "Nam@Nuncmauriselit.ca",
        Photo = "https://randomuser.me/api/portraits/men/89.jpg", Age = 30,
        StreetAddress = "P.O. Box 942, 5329 Fames Av.", City = "Rochester", State = "Minnesota", Zip = "45377",
        Colors = ""
      },
      new Person
      {
        FirstName = "Declan", LastName = "Bond", Email = "Nulla.tincidunt.neque@metusvitaevelit.ca",
        Photo = "https://randomuser.me/api/portraits/men/90.jpg", Age = 35, StreetAddress = "Ap #345-5406 Eu Ave",
        City = "Savannah", State = "Georgia", Zip = "33340", Colors = ""
      },
      new Person
      {
        FirstName = "Elliott", LastName = "Garrett", Email = "magna.Cras.convallis@sedpede.com",
        Photo = "https://randomuser.me/api/portraits/men/91.jpg", Age = 40, StreetAddress = "6024 In Road",
        City = "Las Vegas", State = "NV", Zip = "49824", Colors = "red"
      },
      new Person
      {
        FirstName = "Jelani", LastName = "Holland", Email = "nunc.sed.libero@Donecestmauris.edu",
        Photo = "https://randomuser.me/api/portraits/men/92.jpg", Age = 27,
        StreetAddress = "P.O. Box 625, 2741 Ut St.", City = "Casper", State = "WY", Zip = "53822",
        Colors = "violet, yellow, red, orange, blue"
      },
      new Person
      {
        FirstName = "Nathan", LastName = "Santiago", Email = "leo.Cras@nullaanteiaculis.org",
        Photo = "https://randomuser.me/api/portraits/men/93.jpg", Age = 29,
        StreetAddress = "Ap #383-7067 Vestibulum Street", City = "Kailua", State = "Hawaii", Zip = "83131",
        Colors = "indigo, violet"
      },
      new Person
      {
        FirstName = "Colorado", LastName = "Conway", Email = "nisi.nibh.lacinia@sagittisNullamvitae.org",
        Photo = "https://randomuser.me/api/portraits/men/94.jpg", Age = 48, StreetAddress = "715-2741 Urna. St.",
        City = "Fayetteville", State = "AR", Zip = "71288", Colors = "red, violet, blue"
      },
      new Person
      {
        FirstName = "Reece", LastName = "Johnston", Email = "pede.ac@mifelis.ca",
        Photo = "https://randomuser.me/api/portraits/men/95.jpg", Age = 18, StreetAddress = "495-6101 Sociis Rd.",
        City = "Orlando", State = "FL", Zip = "35309", Colors = "indigo, violet"
      },
      new Person
      {
        FirstName = "Tarik", LastName = "Delaney", Email = "dapibus.quam.quis@dolor.co.uk",
        Photo = "https://randomuser.me/api/portraits/men/96.jpg", Age = 63, StreetAddress = "474-7188 Mollis. Street",
        City = "Lewiston", State = "ME", Zip = "29650", Colors = "red, yellow"
      },
      new Person
      {
        FirstName = "Tucker", LastName = "Yang", Email = "enim.diam.vel@pharetra.com",
        Photo = "https://randomuser.me/api/portraits/men/97.jpg", Age = 45,
        StreetAddress = "Ap #525-3400 Magna Avenue", City = "Biloxi", State = "Mississippi", Zip = "71889",
        Colors = "blue, red, orange"
      },
      new Person
      {
        FirstName = "Eric", LastName = "Edwards", Email = "molestie.arcu@milaciniamattis.net",
        Photo = "https://randomuser.me/api/portraits/men/98.jpg", Age = 54,
        StreetAddress = "Ap #827-2158 Aliquet Ave", City = "Phoenix", State = "AZ", Zip = "85986", Colors = ""
      },
      new Person
      {
        FirstName = "Tanner", LastName = "Burton", Email = "mus@Ut.ca",
        Photo = "https://randomuser.me/api/portraits/men/99.jpg", Age = 52, StreetAddress = "838 Mi. Ave",
        City = "Erie", State = "Pennsylvania", Zip = "61876", Colors = "green, orange"
      }
    };
  }
}
