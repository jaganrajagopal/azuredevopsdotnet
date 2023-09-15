namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Testresultpass()
        {
            var a = 10;
            bool result = false;
            if (a==10)
            {
                 result = true;
            }
            
            Assert.True(result, "Pass result");
            //Assert.False(result, "1 should not be prime");
        }
    }
}