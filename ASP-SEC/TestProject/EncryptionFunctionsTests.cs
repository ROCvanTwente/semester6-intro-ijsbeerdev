using AspSec01.Models;

namespace TestProject
{
    public class EncryptionFunctionsTests
    {
        [Fact]
        public void Encrypt_Then_Decrypt_ReturnsOriginal()
        {
            string input = "Hello123!";
            int key = 5;

            var encrypted = EncryptionFunctions.Encrypt(input, key);
            var decrypted = EncryptionFunctions.Decrypt(encrypted, key);

            Assert.Equal(input, decrypted);
        }

        [Fact]
        public void Encrypt_KnownInput_ReturnsExpectedOutput()
        {
            string input = "A1z";
            int key = 5;
            string expected = "F64";

            string actual = EncryptionFunctions.Encrypt(input, key);

            Assert.Equal(expected, actual);
        }
    }

}