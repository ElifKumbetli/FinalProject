using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash
            //Burası verdiğimiz bir password ün Hash ini oluşturuyor.
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //Buradaki key ilgili kullandığımız algoritmanın o an oluşturduğu key değeridir.
                //Her kullanıcı için bir key oluşturur
                passwordSalt = hmac.Key;//Salt olarak hmac in Key değerini kullanıyoruz.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        //Verify:Doğrula yani PasswordHash ini doğrula
        //Bu kısım sonradan sisteme girmek isteyen kişinin password' ün bizim veri kaynağımızdaki
        //
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        //out olmamalı çünkü bu değerleri biz vereceğiz

        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                //computed:hesaplanan
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i<computedHash.Length; i++)
                {
                    if (computedHash[i]!= password[i]) //v.tabanından gönderilen hash in i. değerine
                                                       //eşit değilse 
                    {
                        return false; //iki değer birb. eşleşmiyor.
                    }
                }
                return true; //eşleşir ise
            }
  
        }
    }
}
