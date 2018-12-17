using FluentAssertions;
using Xunit;

namespace PeopleApp.Shared
{
  public class SampleTest
  {
    [Fact]
    public void should_be_true()
    {
      true.Should().Be(true); 
    }
  }
}
