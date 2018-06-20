using Application.Implements;
using Domain.Entities;
using Infraestructura.Data.Base;
using Infraestructure.Data;
using Infraestructure.Data.Repositories;
using SirccELC.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                System.Console.Clear();

                System.Console.WriteLine("      MENU GENERAL");
                System.Console.WriteLine("  1º) BANCO");
                System.Console.WriteLine("  2º) TRANSCOLBA S.A.S");
                System.Console.WriteLine("  3º) Salir");
                System.Console.Write("  Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        System.Console.Clear();
                        ProgramBanco pb = new ProgramBanco();
                        pb.menu();
                        // Continuar lógica y extraer métodos //
                        break;

                    case '2':
                        System.Console.Clear();
                        frmPrincipal form = new frmPrincipal();
                        form.ShowDialog();
                        ProgramTranscolba pt = new ProgramTranscolba();
                        pt.menu();
                        // Continuar lógica y extraer métodos //
                        break;

                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("saliendo del programa..   ");
                        Environment.Exit(0);
                        // Continuar lógica y extraer métodos //
                        break;
                }


            } while (true);
        }
    }
}
