using Aplication.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class ShowZodiac
    {
       
        

        public void showZ(FormViewModel userData) 
        {
            if (userData.month == 12) 
            {
                if (userData.birthday >= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "capricornio" });
                }
                else if (userData.birthday <= 21) 
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "sagitario" });
                }
            }
            if (userData.month == 11) 
            {
                if (userData.birthday >= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "sagitario" });
                }
                else if (userData.birthday <= 21)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "escorpio" });
                }
            }
            if (userData.month == 10)
            {
                if (userData.birthday >= 23)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "escorpio" });
                }
                else if (userData.birthday <= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "libra" });
                }
            }
            if (userData.month == 9)
            {
                if (userData.birthday >= 23)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "libra" });
                }
                else if (userData.birthday <= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "virgo" });
                }
            }
            if (userData.month == 8)
            {
                if (userData.birthday >= 23)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "virgo" });
                }
                else if (userData.birthday <= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "leo" });
                }
            }
            if (userData.month == 7)
            {
                if (userData.birthday >= 23)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "leo" });
                }
                else if (userData.birthday <= 22)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "cancer" });
                }
            }
            if (userData.month == 6)
            {
                if (userData.birthday >= 21)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "cancer" });
                }
                else if (userData.birthday <= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "geminis" });
                }
            }
            if (userData.month == 5)
            {
                if (userData.birthday >= 21)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "geminis" });
                }
                else if (userData.birthday <= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "tauro" });
                }
            }
            if (userData.month == 4)
            {
                if (userData.birthday >= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "tauro" });
                }
                else if (userData.birthday <= 19)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "aries" });
                }
            }
            if (userData.month == 3)
            {
                if (userData.birthday >= 21)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "aries" });
                }
                else if (userData.birthday <= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "picis" });
                }
            }
            if (userData.month == 2)
            {
                if (userData.birthday >= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "picis" });
                }
                else if (userData.birthday <= 19)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "acuario" });
                }
            }
            if (userData.month == 1)
            {
                if (userData.birthday >= 21)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "acuario" });
                }
                else if (userData.birthday <= 20)
                {
                    Repositori.Repositori.Instance.zl.ZodiacList.Add(new ZodiacViewModel { ZodiacName = "capricornio" });
                }
            }
        }

        public ZodiacListViewModel getAll() 
        {
            return Repositori.Repositori.Instance.zl;
        }
    }
}
