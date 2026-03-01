using NUnit.Framework;
using SecureUserApp.Services;

namespace SecureUserApp.Tests
{
    public class AuthTests
    {
        private AuthService auth;

        [SetUp]
        public void Setup()
        {
            auth = new AuthService();
        }

        [Test]
        public void Register_ShouldReturnTrue_ForNewUser()
        {
            var result = auth.Register("vinay", "pass123");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Authenticate_ShouldReturnTrue_ForCorrectCredentials()
        {
            auth.Register("vinay", "pass123");
            var result = auth.Authenticate("vinay", "pass123");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Authenticate_ShouldReturnFalse_ForWrongPassword()
        {
            auth.Register("vinay", "pass123");
            var result = auth.Authenticate("vinay", "wrongpass");
            Assert.That(result, Is.False);
        }

        [Test]
        public void EncryptDecrypt_ShouldReturnOriginalText()
        {
            string original = "SensitiveData";

            string encrypted = EncryptionService.Encrypt(original);
            string decrypted = EncryptionService.Decrypt(encrypted);

            Assert.That(encrypted, Is.Not.EqualTo(original));
            Assert.That(decrypted, Is.EqualTo(original));
        }
    }
}