using System;
using System.Collections.Generic;
using System.Text;

namespace FormativaN2.Clases
{
    class MyDate
    {
        private long day;
        private long month;
        private long year;

        public MyDate(long day, long month, long year)
        {
            if (Validar(day, month, year))
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                Console.WriteLine("Fecha invalida !!");
            }
        }

        public void mostrarFecha()
        {
            Console.WriteLine("La fecha es {0}-{1}-{2}", this.day, this.month, this.year);
        }

        public bool Validar(long day, long month, long year)
        {
            if (!(year > 0))
            {
                return false;
            }
            if (!(1 <= month && month <= 12))
            {
                return false;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (!(1 <= day && day >= 31))
                    {
                        return false;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (!(1 <= day && day >= 30))
                    {
                        return false;
                    }
                    break;
                case 2:
                    if ((year % 4 == 0) && (year % 100 != 0 || year % 400 == 0))
                    {
                        if (!(1 <= day && day <= 29))
                        {
                            return false;
                        }
                        else
                        {
                            if (!(1 <= day && day <= 28))
                            {
                                return false;

                            }
                        }

                    }
                    break;
            }
            return true;

        }

        public void setDay(long day)
        {
            if (Validar(day, month, year))
            {
                this.day = day;
            }
            else
            {
                Console.WriteLine("El día es invalido !!");
            }
        }


        public void setMonth(long month)
        {
            if (Validar(day, month, year))
            {
                this.month = month;
            }
            else
            {
                Console.WriteLine("El mes es invalido !!");
            }
        }


        public void setYear(long year)
        {
            if (Validar(day, month, year))
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("El año es invalido !!");
            }
        }


        public long getDay()
        {
            return this.day;
        }
        public long getMoth()
        {
            return this.month;
        }
        public long getYear()
        {
            return this.year;
        }

    }
}
