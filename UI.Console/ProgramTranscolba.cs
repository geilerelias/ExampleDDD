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
                        #region   Crear Componente a maquinaria

                        AgregarComponenteAMaquinariaService _service = new AgregarComponenteAMaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));
                        var request = new AgregarComponenteAMaquinariaRequest() { MaquinariaPlaca = "123abc", Descripcion = "sistema de engranaje", Nombre = "Piñon", Referencia = "12345ywtwq" };

                        AgregarComponenteAMaquinariaResponse response = _service.Ejecutar(request);

                        System.Console.WriteLine(response.Mensaje);
                        #endregion

                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':

                        #region  Eliminar Componente
                        System.Console.Clear();
                        System.Console.WriteLine("Eliminar Componente");
                        string nombre = "venezuela";
                        //Country coun = service.Find(nombre);
                        //service.Delete(coun);
                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':
                        #region  Listar Componente
                        //List<Country> countries = service.GetAll().ToList();
                        //foreach (var item in countries)
                        //{
                        //    System.Console.WriteLine(item.Name);
                        //}
                        #endregion
                        System.Console.Clear();
                        System.Console.WriteLine("Listar Componentes");
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
            AgregarMaquinariaService serviceAgregar = new AgregarMaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));
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
                        #region  Crear Maquinaria
                        System.Console.WriteLine("Agregando Maquinaria");
                        System.Console.ReadLine();
                        Maquinaria maquinaria = new Maquinaria();
                        System.Console.WriteLine("Digite la Placa");
                        maquinaria.Placa=System.Console.ReadLine();

                        System.Console.WriteLine("Digite la Marca");
                        maquinaria.Marca=System.Console.ReadLine();

                        System.Console.WriteLine("Digite la Linea");
                        maquinaria.Linea=System.Console.ReadLine();

                        System.Console.WriteLine("Digite el Modelo");
                        maquinaria.Modelo=System.Console.ReadLine();

                        System.Console.WriteLine("Digite el  Color");
                        maquinaria.Color=System.Console.ReadLine();

                        System.Console.WriteLine("Digite la Fecha de Adquisicion");
                        maquinaria.FechaAdquisicion=System.Console.ReadLine();

                        System.Console.WriteLine("Digite el numero de  Chasi");
                        maquinaria.Chasi=System.Console.ReadLine();

                        System.Console.WriteLine("Digite la referencia del  Motor");
                        maquinaria.Motor=System.Console.ReadLine();


                            
                        var request = new AgregarMaquinariaRequest() { Placa = maquinaria.Placa, Marca = maquinaria.Marca, Linea = maquinaria.Linea, Modelo = maquinaria.Modelo, Color = maquinaria.Color, FechaAdquisicion = maquinaria.FechaAdquisicion, Chasi = maquinaria.Chasi, Motor = maquinaria.Motor };

                        AgregarMaquinariaResponse response = serviceAgregar.Agregar(request);

                        System.Console.WriteLine(response.Mensaje);
                        #endregion

                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        #region  Eliminar Maquinaria
                        System.Console.Clear();
                        System.Console.WriteLine("Eliminar Maquinaria");
                        //string nombre = "venezuela";
                        //Country coun = service.Find(nombre);
                        //service.Delete(coun);
                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':

                        #region  Listar Country
                        System.Console.Clear();
                        System.Console.WriteLine("Listar Maquinaria");
                        MaquinariaService serviceListar = new MaquinariaService(new UnitOfWork(context), new MaquinariaRepository(context));
                        List<Maquinaria> maquinarias = serviceListar.GetAll().ToList();
                        foreach (var item in maquinarias)
                        {
                            System.Console.WriteLine("--------------------------------------------");
                            System.Console.WriteLine(item.Placa);
                            System.Console.WriteLine(item.Marca);
                            System.Console.WriteLine(item.FechaAdquisicion);
                            System.Console.WriteLine("Placa");
                            System.Console.WriteLine("Marca");
                            System.Console.WriteLine("Linea");
                            System.Console.WriteLine("Modelo");
                            System.Console.WriteLine("Color");
                            System.Console.WriteLine("Adquisicion");
                            System.Console.WriteLine("Numero de Chasi");
                            System.Console.WriteLine("Numero de Motor");
                            System.Console.WriteLine("--------------------------------------------");
                        }
                       
                        // Continuar lógica y extraer métodos //
                        System.Console.ReadKey();
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
