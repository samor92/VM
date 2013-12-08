using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1_1
{
    class Ghauss
    {

        static public void makeMatrix(int n, int k, out double[] a, out double[] b, out double[] c, out double[] p, out double[] q, double range)
        {
            a = new double[n - 1];            
            c = new double[n - 1];
            b = new double[n];
            q = new double[n];
            p = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                {
                    a[i] = (r.NextDouble() * 2 * range - range) * 1; //* 100;
                    c[i] = r.NextDouble() * 2 * range - range;
                }
                b[i] = (r.NextDouble() * 2 * range - range) * 1;
                p[i] = r.NextDouble() * 2 * range - range;
                q[i] = r.NextDouble() * 2 * range - range;
            }

            a[k + 1] = q[k + 2];
            b[k + 1] = q[k + 1];
            c[k] = q[k];

            a[k] = p[k + 1];
            b[k] = p[k];
            c[k - 1] = p[k - 1];
        }

        static public double[] makeX(int n, int range)
        {
            double[] x = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = r.NextDouble() * 2 - 1;
            }
            return x;                
        }

        static public double[] makeF(int n, int k, double[] a, double[] b, double[] c, double[] p, double[] q, double[] x)
        {
            double[] f = new double[n];

            f[n - 1] = p[n - 1]*x[k] + q[n - 1]*x[k + 1] + a[n - 2] * x[n - 2] + b[n - 1] * x[n - 1];
            f[0] = b[0] * x[0] + c[0] * x[1] + p[0] * x[k] + q[0] * x[k + 1];

            for (int i = 1; i < (k - 1); i++)
            {
                f[i] = a[i - 1] * x[i - 1] + b[i] * x[i] + c[i] * x[i + 1] + p[i] * x[k] + q[i] * x[k + 1];
            }
            
            f[k - 1] /*f[n - k]*/ = a[k - 2] * x[k - 2] + b[k - 1] * x[k - 1] + p[k - 1] * x[k] + q[k - 1] * x[k + 1];
            f[k] /*f[n - k - 1]*/ = a[k - 1] * x[k - 1] + p[k] * x[k] + q[k] * x[k + 1];
            f[k + 1] /*f[n - k - 2]*/ = p[k + 1] * x[k] + q[k + 1] * x[k + 1] + c[k + 1] * x[k + 2];
            f[k + 2] /*f[n - k - 3]*/ = p[k + 2] * x[k] + q[k + 2] * x[k + 1] + b[k + 2] * x[k + 2] + c[k + 2] * x[k + 3];

            for (int i = k + 3; i < n - 1; i++)
            {
                f[i] = a[i - 1] * x[i - 1] + b[i] * x[i] + c[i] * x[i + 1] + p[i] * x[k] + q[i] * x[k + 1];
            }

            return f;
        }


        static public double[] Solve(int n, int k, double[] a, double[] b, double[] c, double[] p, double[] q, double[] f, out double accur, double[] x_)
        {

            double[] x = new double[n];
            double[] _x = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                _x[i] = 1;
            }

            // Вычисление вектора F
            double[] _f = makeF(n, k, a, b, c, p, q, _x);

            double r;

            //Идем от первой до k-й строки, делаем на главной диагонали 1, с ее помощью обнуляем элементы нижней поддиагонали и элементы векторов p, q:
            for (int i = 0; i <= k - 1; i++)
            {
                r = 1 / b[i];
                b[i] = 1;
                c[i] = r * c[i];
                p[i] = r * p[i];
                q[i] = r * q[i];
                
                f[i] = r * f[i];
                _f[i] = r * _f[i];

                r = a[i];
                a[i] = 0;
                b[i + 1] = b[i + 1] - r * c[i];
                p[i + 1] = p[i + 1] - r * p[i];
                q[i + 1] = q[i + 1] - r * q[i];

                f[i + 1] = f[i + 1] - r * f[i];
                _f[i + 1] = _f[i + 1] - r * _f[i];
                c[k] = q[k];
                c[k - 1] = p[k - 1];
            }

            // Идем от последней до k+1-й строки, делаем на главной диагонали 1, с ее помощью обнуляем элементы верхней кодиагонали и элементы векторов p, q:
            for (int i = n - 1; i >= k + 2; i--)
            {
                r = 1 / b[i];
                b[i] = 1;
                a[i - 1] = r * a[i - 1];
                p[i] = r * p[i];
                q[i] = r * q[i];

                f[i] = r * f[i];
                _f[i] = r * _f[i];

                r = c[i - 1];
                c[i - 1] = 0;
                b[i - 1] = b[i - 1] - r * a[i - 1];
                p[i - 1] = p[i - 1] - r * p[i];
                q[i - 1] = q[i - 1] - r * q[i];
                
                f[i - 1] = f[i - 1] - r * f[i];
                _f[i - 1] = _f[i - 1] - r * _f[i];
                a[k + 1] = q[k + 2];
                a[k] = p[k + 1];
            }

            r = 1 / b[k + 1];
            b[k + 1] = 1;
            f[k + 1] = r * f[k + 1];
            _f[k + 1] = r * _f[k + 1];
            p[k + 1] = r * p[k + 1];
            
            q[k + 1] = b[k + 1];
            a[k] = p[k + 1];

            r = c[k];
            c[k] = 0;      
            q[k] = c[k];

            b[k] = b[k] - r * a[k]; 
            p[k] = b[k];
            
            f[k] = f[k] - r * f[k + 1];
            _f[k] = _f[k] - r * _f[k + 1];

            r = 1 / b[k];
            b[k] = 1;
            f[k] = r * f[k];
            _f[k] = r * _f[k];
            
            //b[k] получил = 1 досчитать
            //initX(out xResultVector, n, 0);
            //вторая строка квадрата
            _x[k] = _f[k];
            x[k] = f[k];
            //первая строка квадрата
            _x[k + 1] = _f[k + 1] - _x[k] * a[k];
            x[k + 1] = f[k + 1] - x[k] * a[k];
            
            _x[k - 1] = _f[k - 1] - q[k - 1] * _x[k + 1] - p[k - 1] * _x[k];
            x[k - 1] = f[k - 1] - q[k - 1] * x[k + 1] - p[k - 1] * x[k];

            _x[k + 2] = _f[k + 2] - q[k + 2] * _x[k + 1] - p[k + 2] * _x[k];
            x[k + 2] = f[k + 2] - q[k + 2] * x[k + 1] - p[k + 2] * x[k];
            
            for (int i = k - 2; i >= 0; i--)
            {
                x[i] = f[i] - q[i] * x[k + 1] - p[i] * x[k] - c[i] * x[i + 1];
                _x[i] = _f[i] - q[i] * _x[k + 1] - p[i] * _x[k] - c[i] * _x[i + 1];
            }

            for (int i = k + 3; i <= n - 1; i++)
            {
                _x[i] = _f[i] - q[i] * _x[k + 1] - p[i] * _x[k] - a[i - 1] * _x[i - 1];
                x[i] = f[i] - q[i] * x[k + 1] - p[i] * x[k] - a[i - 1] * x[i - 1];
            }

            
            accur = 0;
            double g;
            for (int z = 0; z < n; z++)
            {
                g = Math.Abs(_x[z] - 1);
                if (g > accur)
                    accur = g;
            }
            return x;
        }        
    }
}
