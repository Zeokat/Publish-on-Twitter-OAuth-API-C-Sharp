using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.IO;

namespace Twitter_OAuth__Crear_post____Vozidea.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llaves de acceso de la aplicación Twitter
            var oauth_token = textBox_atoken.Text;
            var oauth_token_secret = textBox_atokensecret.Text;
            var oauth_consumer_key = textBox_consumerk.Text;
            var oauth_consumer_secret = textBox_consumers.Text;

            // Caracteristicas de la implementacion OAuth
            var oauth_version = "1.0";
            var oauth_signature_method = "HMAC-SHA1";

            // Detalles del mensaje de la API
            var mensaje = textBox_post.Text;
            var resource_url = "https://api.twitter.com/1.1/statuses/update.json";
            var request_type = "POST";

            // Detalles de creación de la cabecera de autentificación
            // Creamos el oauth_nonce
            var oauth_nonce = CreateNonce();
            // Creamos el oauth_timestamp
            var oauth_timestamp = CreateTimestamp();
            // Creamos el oauth_signature
            string oauth_signature = CreateOAuthSignature(oauth_consumer_key, oauth_nonce, oauth_signature_method,
                oauth_timestamp, oauth_token, oauth_version, mensaje, resource_url, request_type, oauth_consumer_secret, oauth_token_secret);

            // Construimos la cabecera de autentificación combinando todos los valores
            var headerFormat = "OAuth oauth_consumer_key=\"{0}\", oauth_nonce=\"{1}\", oauth_signature=\"{2}\", " +
                               "oauth_signature_method=\"{3}\", oauth_timestamp=\"{4}\", " +
                               "oauth_token=\"{5}\", oauth_version=\"{6}\"";

            var authHeader = string.Format(headerFormat,
                                    Uri.EscapeDataString(oauth_consumer_key),
                                    Uri.EscapeDataString(oauth_nonce),
                                    Uri.EscapeDataString(oauth_signature),
                                    Uri.EscapeDataString(oauth_signature_method),
                                    Uri.EscapeDataString(oauth_timestamp),
                                    Uri.EscapeDataString(oauth_token),
                                    Uri.EscapeDataString(oauth_version)
                            );

            // Realizamos la petición HTTP con el método POST
            var postdata = "status=" + URLEncode(mensaje);
            ServicePointManager.Expect100Continue = false;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(resource_url);
            request.Headers.Add("Authorization", authHeader);
            request.Method = request_type;
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            using (Stream stream = request.GetRequestStream())
            {
                byte[] content = ASCIIEncoding.ASCII.GetBytes(postdata);
                stream.Write(content, 0, content.Length);
            }
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            string json = sr.ReadToEnd();
            sr.Close();
            response.Close();

            textBox_post.Text = json;
        }

        private string CreateNonce()
        {
            var oauth_nonce = CalculateMD5Hash(DateTime.Now.Ticks.ToString());
            return oauth_nonce;
        }

        private string CreateTimestamp()
        {
            var timeSpan = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var oauth_timestamp = Convert.ToInt64(timeSpan.TotalSeconds).ToString();
            return oauth_timestamp;
        }

        private string CreateOAuthSignature(string oauth_consumer_key, string oauth_nonce, string oauth_signature_method,
            string oauth_timestamp, string oauth_token, string oauth_version, string mensaje, string resource_url,
            string request_type, string oauth_consumer_secret, string oauth_token_secret)
        {
            var baseFormat = "oauth_consumer_key={0}&oauth_nonce={1}&oauth_signature_method={2}" +
                            "&oauth_timestamp={3}&oauth_token={4}&oauth_version={5}&status={6}";

            var baseString = string.Format(baseFormat,
                                        oauth_consumer_key,
                                        oauth_nonce,
                                        oauth_signature_method,
                                        oauth_timestamp,
                                        oauth_token,
                                        oauth_version,
                                        URLEncode(mensaje)
                                        );
            baseString = string.Concat(request_type, "&", Uri.EscapeDataString(resource_url), "&", Uri.EscapeDataString(baseString));


            var SHA_Key = string.Concat(Uri.EscapeDataString(oauth_consumer_secret), "&", Uri.EscapeDataString(oauth_token_secret));
            string oauth_signature;
            using (HMACSHA1 hasher = new HMACSHA1(ASCIIEncoding.ASCII.GetBytes(SHA_Key)))
            {
                oauth_signature = Convert.ToBase64String(hasher.ComputeHash(ASCIIEncoding.ASCII.GetBytes(baseString)));
            }

            return oauth_signature;
        }

        public string CalculateMD5Hash(string input)
        {
            // Paso 1, calculamos el MD5 a partir del input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // Paso 2, convertimos el byte array a una cadena hexadecimal
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }

        private static string URLEncode(string s)
        {
            var sb = new StringBuilder();

            foreach (byte c in Encoding.UTF8.GetBytes(s))
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9') || c == '-' || c == '_' || c == '.' || c == '~')
                    sb.Append((char)c);
                else
                {
                    sb.AppendFormat("%{0:X2}", c);
                }
            }
            return sb.ToString();
        }
    }
}
