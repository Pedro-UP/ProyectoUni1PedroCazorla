using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUni1PedroCazorla
{
    class ConvertirMonedas
    {           
        public Double ARSConvertirMXN(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.28;
            return mx;
        }
        public Double BOBConvertirMXN(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 3.06;
            return mx;
        }
        public Double BRLConvertirMXN(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 3.92;
            return mx;
        }
        public Double VEFConvertirMXN(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.0001;
            return mx;
        }
        public Double MXNConvertirMXN(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.00;
            return mx;
        }
        /*----------------------------------------*/
        public Double ARSConvertirARS(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.00;
            return mx;
        }
        public Double BOBConvertirARS(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 10.91;
            return mx;
        }
        public Double BRLConvertirARS(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 13.97;
            return mx;
        }
        public Double VEFConvertirARS(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.0003;
            return mx;
        }
        public Double MXNConvertirARS(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 3.56;
            return mx;
        }

        /*----------------------------------------*/
        public Double ARSConvertirBOB(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.0917;
            return mx;
        }
        public Double BOBConvertirBOB(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.00;
            return mx;
        }
        public Double BRLConvertirBOB(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.28;
            return mx;
        }
        public Double VEFConvertirBOB(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.00003;
            return mx;
        }
        public Double MXNConvertirBOB(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.33;
            return mx;
        }

        /*----------------------------------------*/
        public Double ARSConvertirBRL(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.0716;
            return mx;
        }
        public Double BOBConvertirBRL(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.78;
            return mx;
        }
        public Double BRLConvertirBRL(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.00;
            return mx;
        }
        public Double VEFConvertirBRL(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.00002;
            return mx;
        }
        public Double MXNConvertirBRL(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 0.26;
            return mx;
        }

        /*----------------------------------------*/
        public Double ARSConvertirVEF(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 3299.0;
            return mx;
        }
        public Double BOBConvertirVEF(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 35989.0;
            return mx;
        }
        public Double BRLConvertirVEF(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 46090.0;
            return mx;
        }
        public Double VEFConvertirVEF(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 1.00;
            return mx;
        }
        public Double MXNConvertirVEF(double numero1)
        {
            Double mx = 0;
            mx = numero1 * 11760;
            return mx;
        }

    }
}
