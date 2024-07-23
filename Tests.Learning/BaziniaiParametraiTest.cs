using Learning.Classes;
using Learning.Enums;

namespace Tests.Learning
{
    public class BaziniaiParametraiTest
    {

        [Theory]
        [InlineData( "jono durys",  SpalvaEnum.MĖLYNA,  "pavadinimas: jono durys, spalva: MĖLYNA")]
        [InlineData( "petro durys",  SpalvaEnum.JUODA,  "pavadinimas: petro durys, spalva: JUODA")]
        [InlineData( "algio durys",  SpalvaEnum.BALTA,  "pavadinimas: algio durys, spalva: BALTA")]
        public void TestGetInfo(string pavadinimas, SpalvaEnum spalva, string expectedResult)
        {
            var baziniaiParametrai = new BaziniaiParametrai(pavadinimas, spalva);

            var actualResult = baziniaiParametrai.GetInfo();

            //Assert.Equal(expectedResult, actualResult);
        }
    }
}
