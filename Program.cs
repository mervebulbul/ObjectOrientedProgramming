//************************************************************************
//**                                                                    **
//**   STUDENT NAME. ........ ...... :Merve Bülbül                      **
//**   STUDENT NUMBER . ...... .. .... :B211202350                      **
//************************************************************************
using System;

namespace OOPHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            CRYPT crypt = new CRYPT();


            while (crypt.control == false)
            {

                //takes input from the keyboard
                Console.Write("Enter a four-digit number: ");
                crypt.n = Console.ReadLine();
                

                //desired methods

                //This method inputs the number from keyboard. And controls it.
                crypt.inputNumber();

                //This method includes operations for encryption.
                crypt.encryptNumber();

                //This method prints the encrypted number
                crypt.printEncryptedNumber();

                //returns the encrypted number to original number
                crypt.decryptNumber();

                //prints the original number
                crypt.printDecryptedNumber();
                Console.ReadKey();
            }


        }


        //The CRYPT class includes all necessary functions
        class CRYPT
        {

            int d1;
            int d2;
            int d3;
            int d4;
            public string n;
            public int n1;
            public bool control = false;

            public void inputNumber()
            {
                //It returns the input from string to integer
                n1 = Convert.ToInt32(n);
                int n2 = n1;

                //this part finds digit number
                int sayac = 0;
                while (n2 > 0)
                {
                    n2 /= 10;
                    sayac++;
                }

                //It controls whether digit is 4 or not 4
                if (sayac == 4)
                {
                    control = true;
                }
                else
                {
                    //It goes to while method that in the Program class and repeats the while loop until the user enters it correctly
                    control = false;
                }


            }

            public void encryptNumber()
            {

                 d1 = ((n1 / 1000) + 7) % 10;
                 d2 = ((n1 / 100) + 7) % 10;
                 d3 = ((n1 / 10) + 7) % 10;
                 d4 = ((n1 + 7) % 10);

            }
            public void decryptNumber()
            {
                d1 = (n1 / 1000) % 10;
                d2 = (n1 / 100) % 10;
                d3 = (n1 / 10) % 10;
                d4 = n1 % 10;
               
            }

            public void printEncryptedNumber()
            {
                Console.WriteLine("Encrypted Message......: {0}{1}{2}{3}", d3, d4, d1, d2);

            }

            public void printDecryptedNumber()
            {
                Console.Write("Decrypted Message......: {0}{1}{2}{3}", d1, d2, d3, d4);

            }


        }
    }
}

