using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace ExpresionesNodos
{
    public class Grafico
    {
        #region campos de clase
        private Nodo arbol;
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        private string command = @"/c Batch.bat";
        private int i, j;
        #endregion campos de clase

        #region constructores
        public Grafico(Nodo arbol)
        {
            this.arbol = arbol;
        }
        #endregion constructores

        #region funciones para grafico
        public void DrawTree()
        {
            CreateFileDot();
            ExecuteDot();
        }

        private string CreateFileDot()
        {
            String cadenaDot = "";
            StartFileDot(arbol, ref cadenaDot);
            using (StreamWriter archivo =  new StreamWriter(path + @"\Arbol.dot"))
            {
                archivo.WriteLine(cadenaDot);
                archivo.Close();
            }
            return cadenaDot;
        }

        private void StartFileDot(Nodo arbol, ref string cadenaDot)
        {
            if (arbol != null)
            {
                cadenaDot += "digraph Grafico {\nnode [style=bold, fillcolor=gray];\n";
                Recorrido(arbol, ref cadenaDot);
                cadenaDot += "\n}";
            }
        }

        private void Recorrido(Nodo arbol, ref string cadenaDot)
        {
            if (arbol != null)
            {
                cadenaDot += $"{arbol.Datos}\n";
                if (arbol.NodoIzquierdo != null)
                {
                    i = arbol.Datos.ToString().IndexOf("[");
                    j = arbol.NodoIzquierdo.Datos.ToString().IndexOf("[");
                    cadenaDot += $"{arbol.Datos.ToString().Remove(i)}->{arbol.NodoIzquierdo.Datos.ToString().Remove(j)};\n";
                }
                if (arbol.NodoDerecho != null)
                {
                    i = arbol.Datos.ToString().IndexOf("[");
                    j = arbol.NodoDerecho.Datos.ToString().IndexOf("[");
                    cadenaDot += $"{arbol.Datos.ToString().Remove(i)}->{arbol.NodoDerecho.Datos.ToString().Remove(j)};\n";
                }
                Recorrido(arbol.NodoIzquierdo, ref cadenaDot);
                Recorrido(arbol.NodoDerecho, ref cadenaDot);
            }
        }

        private void ExecuteDot()
        {
            Directory.SetCurrentDirectory(path);
            using (Process proceso = new Process())
            {
                ProcessStartInfo Info = new ProcessStartInfo("cmd", command);
                Info.CreateNoWindow = true;
                proceso.StartInfo = Info;
                proceso.Start();
                proceso.WaitForExit();
                proceso.Close();

            }
        }

        #endregion funciones para grafico
    }
}
