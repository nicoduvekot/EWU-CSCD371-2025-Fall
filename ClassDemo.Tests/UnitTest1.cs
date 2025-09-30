namespace ClassDemo.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("admin", "goodpassword")]
        [InlineData("InigoMontoya", "goodpassword")]
        [InlineData("PrincessButtercup", "goodpassword")]
        public void TryLogin_WithGoodPassword_SuccessfulLogin(string username, string password)
        {
            Program program = new();
            Assert.True(program.TryLogin(username, password));
        }


        [Fact]
        // MethodUnderTest_ConditionUnderTest_ExpectedResult
        public void TryLogin_ValidCredentials_Success()
        {
            Program program = new();
            Assert.True(program.TryLogin(username: "admin", password: "goodpassword"));
        }

        [Fact]
        public void TryLogin_InigoMontoyaValidCredentials_Success()
        {
            Program program = new();
            Assert.True(program.TryLogin(username: "InigoMontoya", password: "goodpassword"));
        }

        [Fact]
        public void TryLogin_InvalidCredentials_Failure()
        {
            Program program = new();
            Assert.False(program.TryLogin(username: "admin", password: "wrongpassword"));
        }

        [Fact]
        public void Login_PrincessButtercupValidCredentials_Success()
        {
            Program program = new();
            program.Login(username: "PrincessButtercup", password: "goodpassword");
        }

        [Fact]
        public void Login_InvalidCredentials_ThrowsInvalidOperationException()
        {
            Program program = new();
            Assert.Throws<InvalidOperationException>(
                () => program.Login(username: "admin", password: "wrongpassword")
                );
        }
    }
}
