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
    class ProgramTranscolba
    {
         public void menu()
        {
            bool seguir = true;
            do
            {
                BancoContext context = new BancoContext();
                MaquinariaService service = new MaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));

                System.Console.Clear();
                System.Console.WriteLine("MENU DEL SISTEMA TRANSCOLBA S.A.S");
                System.Console.WriteLine("1º) Maquinaria");
                System.Console.WriteLine("2º) Componentes");
                System.Console.WriteLine("3º) Tareas");
                System.Console.WriteLine("4º) Salir");
                System.Console.Write("Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        menuMaquinaria(context);

                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        menuComponentes(context);
                        break;
                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("Consignar Cuenta Bancaria");
                        //CrearCuentaBancaria(context);
                        // Continuar lógica y extraer métodos //
                        break;

                    case '4':
                        System.Console.Clear();
                        System.Console.WriteLine("saliendo del programa..   ");
                        seguir = false;
                        // Continuar lógica y extraer métodos //
                        break;
                }


            } while (seguir);
        }

         void menuComponentes(BancoContext context)
        {


            System.Console.ReadKey();
            char seguir = 's';
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("MENU COMPONENTES");
                System.Console.WriteLine("1º) Crear Componente a maquinaria");
                System.Console.WriteLine("2º) Eliminar Componente a maquinaria");
                System.Console.WriteLine("3º) Listar Componente de maquinaria");
                System.Console.WriteLine("4º) Regresar");
                System.Console.Write("Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        System.Console.Clear();
                        #region  Consignar

                        AgregarComponenteAMaquinariaService _service = new AgregarComponenteAMaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));
                        var request = new AgregarComponenteAMaquinariaRequest() { MaquinariaPlaca = "123abc", Descripcion = "sistema de engranaje", Nombre = "Piñon", Referencia = "12345ywtwq" };

                        AgregarComponenteAMaquinariaResponse response = _service.Ejecutar(request);

                        System.Console.WriteLine(response.Mensaje);
                        #endregion

                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        System.Console.Clear();
                        System.Console.WriteLine("Eliminar Country");
                        #region  Eliminar Country
                        string nombre = "venezuela";
                        //Country coun = service.Find(nombre);
                        //service.Delete(coun);
                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("Listar Country");
                        #region  Listar Country
                        //List<Country> countries = service.GetAll().ToList();
                        //foreach (var item in countries)
                        //{
                        //    System.Console.WriteLine(item.Name);
                        //}
                        #endregion
                        // Continuar lógica y extraer métodos //
                        System.Console.ReadKey();
                        break;
                    case '4':
                        System.Console.Clear();
                        System.Console.WriteLine("Regresando al principal..   ");
                        System.Console.ReadKey();
                        seguir = 'n';
                        break;
                }


            } while (seguir == 's');
        }

         void menuMaquinaria(BancoContext context)
        {

            MaquinariaService service = new MaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));
            char seguir = 's';
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("MENU MAQUINARIA");
                System.Console.WriteLine("1º) Crear Maquinaria");
                System.Console.WriteLine("2º) Eliminar Maquinaria");
                System.Console.WriteLine("3º) Listar Maquinaria");
                System.Console.WriteLine("4º) Regresar");
                System.Console.Write("Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        System.Console.Clear();
                        System.Console.WriteLine("Crear Country");
                        #region  Crear Country
                        System.Console.Clear();
                        System.Console.WriteLine("Maquinaria");
                        #region  Crear Maquinaria

                        Maquinaria maquinaria = new Maquinaria();

                        maquinaria.Chasi = "123abc";
                        maquinaria.Color = "rojo";
                        maquinaria.Linea = "caminoneta";
                        maquinaria.Marca = "nissan";
                        maquinaria.Modelo = "2012";
                        maquinaria.Motor = "125-678";
                        maquinaria.Placa = "aaa-58c";
                        maquinaria.FechaAdquisicion = "2018-05-05";

                        service.Create(maquinaria);

                        #endregion

                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        System.Console.Clear();
                        System.Console.WriteLine("Eliminar Country");
                        #region  Eliminar Country
                        //string nombre = "venezuela";
                        //Country coun = service.Find(nombre);
                        //service.Delete(coun);
                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("Listar Country");
                        #region  Listar Country
                        //List<Country> countries = service.GetAll().ToList();
                        //foreach (var item in countries)
                        //{
                        //    System.Console.WriteLine(item.Name);
                        //}
                        #endregion
                        // Continuar lógica y extraer métodos //
                        System.Console.ReadKey();
                        break;
                    case '4':
                        System.Console.Clear();
                        System.Console.WriteLine("Regresando al principal..   ");
                        System.Console.ReadKey();
                        seguir = 'n';
                        break;
                }


            } while (seguir == 's');
        }

    }
}
