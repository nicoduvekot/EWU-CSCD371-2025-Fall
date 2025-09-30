namespace ClassDemo.Tests
{
    public class UnitTest1
    {



        [Fact]
        // MethodUnderTest_ConditionUnderTest_ExpectedResult
        public void Login_ValidCredentials_Success()
        {
            Program program = new();
            Assert.True(program.Login(username: "admin", password: "goodpassword"));
        }

        [Fact]
        public void Login_InigoMontoyaValidCredentials_Success()
        {
            Program program = new();
            Assert.True(program.Login(username: "InigoMontoya", password: "goodpassword"));
        }

        [Fact]
        public void Login_InvalidCredentials_Failure()
        {
            Program program = new();
            Assert.False(program.Login(username: "admin", password: "wrongpassword"));
        }
    }
}
