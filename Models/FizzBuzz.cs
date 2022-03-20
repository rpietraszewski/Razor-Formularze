using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzz
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Required, Range(1, 1000,
            ErrorMessage = "Oczekiwana wartosć {0} z zakresu {1} i {2}.")]
        public int? Number { get; set; }

        public (string, string) getOutput()
        {
            if (Number > 0 && Number <= 1000)
            {
                string outMessage = "FizzBuzz";
                string outMethod = "success";
                if (Number % 3 == 0 && Number % 5 == 0)
                {
                    return (outMessage, outMethod);
                }
                else if (Number % 5 == 0)
                {
                    outMessage = "Buzz";
                    outMethod = "success";
                    return (outMessage, outMethod);
                }
                else if (Number % 3 == 0)
                {
                    outMessage = "Fizz";
                    outMethod = "success";
                    return (outMessage, outMethod);
                }
                else
                {
                    outMessage = ("Liczba: " + Number + " nie spełnia kryteriów FizzBuzz");
                    outMethod = "warning";
                    return (outMessage, outMethod);
                }
            }
            else
            {
                string outMessage = "Podano liczbe spoza oczekiwanego zakresu";
                string outMethod = "warning";
                return (outMessage, outMethod);
            }
        }
    }
}