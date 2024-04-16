using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7
{
    public class Complex
    {
        string element1;
        string element2;
        string answ;
        string action;
        double a1;
        double b1;
        double a2;
        double b2;

        public double A1
        {
            get { return a1; }
            set { a1 = value; }
        }
        public double B1
        {
            get { return b1; }
            set { b1 = value; }
        }
        public double A2
        {
            get { return a2; }
            set { a2 = value; }
        }
        public double B2
        {
            get { return b2; }
            set { b2 = value; }
        }
        public string Answ
        {
            get { return answ; }
            set { answ = value; }
        }

        public string Element1
        {
            get { return element1; }
            set { element1 = value; }
        }
        public string Element2
        {
            get { return element2; }
            set { element2 = value; }
        }
        public string Action
        {
            get { return action; }
            set { action = value; }
        }


        public string complexsum()
        {
            double answ1 = a1 + a2;
            double answ2 = b1 + b2;
            if (answ2 > 0)
            {
                answ = $"{answ1}+{answ2}i";
                return answ;
            }
            else if (answ2 < 0)
            {
                answ = $"{answ1} {answ2}i";
                return answ;
            }
            answ = $"{answ1}+i";
            return $"{answ1}+i";
        }
        public string complexsub()
        {
            double answ1 = a1 - a2;
            double answ2 = b1 - b2;
            if (answ2>0)
            {
                 answ = $"{answ1}+{answ2}i";
                return answ;

            }
            else if (answ2 < 0)
            {
               answ = $"{answ1} {answ2}i";
                return answ;
            }
            answ = $"{answ1}+i";
            return $"{answ1}+i";
        }
        public string complexmult()
        {
            double answ1 = a1 * a2 - b1 * b2;
            double answ2 = a1 * b2 + b1 * a2;
            if (answ2 > 0)
            {
                answ = $"{answ1}+{answ2}i";
                return answ;

            }
            else if (answ2 < 0)
            {
                answ = $"{answ1} {answ2}i";
                return answ;
            }
            answ = $"{answ1}+i";
            return $"{answ1}+i";
        }
    }
}
