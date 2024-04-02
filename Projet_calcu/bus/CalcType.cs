using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_calcu.bus
{
    public class CalcType
    {
        private char calcSymb;
        private double firstNumb;
        private double secondNumb;
        private double answer;

        public char CalcSymb {  get { return calcSymb; } set {  calcSymb = value; } }
        public double FirstNumb { get {  return firstNumb; } set {  firstNumb = value; } }

        public double SecondNumb { get { return secondNumb; } set {  secondNumb = value; } }

        public double Answer { get { return answer; } set { answer = value; } }

        public CalcType() 
        { 
            calcSymb = '+';
            firstNumb = 0;
            secondNumb = 0;
            answer = 0;
        }

        public CalcType(char calcSymb, double firstNumb, double secondNumb, double answer)
        {
            this.calcSymb = calcSymb;
            this.firstNumb = firstNumb;
            this.secondNumb = secondNumb;
            this.answer = answer;
        }

        public string GetCalcState()
        {
            string state;
            if (calcSymb == '+')
            {
                this.answer = this.firstNumb + this.secondNumb;
                this.answer = Math.Round(this.answer, 2);
            } 

            if (calcSymb == '-')
            {
                this.answer = this.firstNumb - this.secondNumb;
                this.answer = Math.Round(this.answer, 2);
            }

            if (calcSymb == '/')
            {
                this.answer = this.firstNumb / this.secondNumb;
                this.answer = Math.Round(this.answer, 2);
            }

            if (calcSymb == '*')
            {
                this.answer = this.firstNumb * this.secondNumb;
                this.answer = Math.Round(this.answer, 2);
            }


            state = this.firstNumb + " " + this.calcSymb + " " + this.secondNumb + " = " + this.answer;

            return state;

        }
    }
}
