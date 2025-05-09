namespace Ders4
{
    public class Customer
    {
        // Private fields
        private string _name;
        private string _surName;
        private int _age;
        private string _email;

        // Public properties
        public string Name
        {
            get => _name;
            set
            {
                textNullCheck(value, "Name");
                _name = value;
            }
        }

        public string SurName
        {
            get => _surName;
            set
            {
                textNullCheck(value, "SurName");
                _surName = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                valueRangeCheck(value, "Age");
                _age = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                textNullCheck(value, "Email");
                checkEmailFormat(value);
                _email = value;
            }
        }

        // Validation methods
        private void textNullCheck(string val, string title)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                throw new ArgumentException($"{title} alanı boş olamaz.");
            }
        }

        private void valueRangeCheck(int val, string title)
        {
            if (val < 0 || val > 200)
            {
                throw new ArgumentOutOfRangeException($"{title} 0-200 aralığında olmalı.");
            }
        }

        private void checkEmailFormat(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new FormatException("Geçerli bir email formatı giriniz.");
            }
        }
    }
}