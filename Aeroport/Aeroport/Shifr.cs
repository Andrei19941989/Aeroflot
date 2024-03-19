namespace Aeroport
{
    public class Shifr//шифрование паролей 
    {
        const string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        private string CodeEncode(string text, int k)
        {
            
            var fullAlfabet = alfabet + alfabet.ToLower();
            var letterQty = fullAlfabet.Length;
            var retVal = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = fullAlfabet.IndexOf(c);
                if (index < 0)
                {
                    
                    retVal += c.ToString();
                }
                else
                {
                    var codeIndex = (letterQty + index + k) % letterQty;
                    retVal += fullAlfabet[codeIndex];
                }
            }

            return retVal;
        }

        
        public string Encrypt(string plainMessage, int key)
            => CodeEncode(plainMessage, key);

       
        public string Decrypt(string encryptedMessage, int key)
            => CodeEncode(encryptedMessage, -key);
    }
}