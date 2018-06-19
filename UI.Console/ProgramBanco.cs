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
   public  class ProgramBanco
    {
        public void menu()
        {
            bool seguir = true;
            do
            {
                BancoContext context = new BancoContext();
                System.Console.Clear();
                System.Console.WriteLine("MENU DEL SISTEMA BANCARIO EN CONSOLA");
                System.Console.WriteLine("1º) Country");
                System.Console.WriteLine("2º) Crear Cuenta Bancaria");
                System.Console.WriteLine("3º) Consignar Cuenta Bancaria");
                System.Console.WriteLine("4º) Crear Persona");
                System.Console.WriteLine("5º) Salir");
                System.Console.Write("Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        System.Console.Clear();
                        System.Console.WriteLine("Country");
                        menuCountry(context);
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        System.Console.Clear();
                        System.Console.WriteLine("Crear Cuenta Bancaria");
                        ConsignarCuentaBancaria(context);
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("Consignar Cuenta Bancaria");
                        CrearCuentaBancaria(context);
                        // Continuar lógica y extraer métodos //
                        break;
                    case '4':
                        System.Console.Clear();
                        System.Console.WriteLine("Crear Persona");
                        // Continuar lógica y extraer métodos //
                        break;
                    case '5':
                        System.Console.Clear();
                        System.Console.WriteLine("saliendo del programa..   ");
                        seguir = false;
                        // Continuar lógica y extraer métodos //
                        break;
                }


            } while (seguir);
        }

        void menuCountry(BancoContext context)
        {

            CountryService service = new CountryService(new UnitOfWork(context), new CountryRepository(context));
            char seguir = 's';
            do
            {
                System.Console.Clear();
                System.Console.WriteLine("MENU COUNTRY");
                System.Console.WriteLine("1º) Crear Country");
                System.Console.WriteLine("2º) Eliminar Country");
                System.Console.WriteLine("3º) Listar Country");
                System.Console.WriteLine("4º) Regresar");
                System.Console.Write("Seleccione una opción:  ");
                switch (System.Console.Read())
                {
                    case '1':
                        System.Console.Clear();
                        System.Console.WriteLine("Crear Country");
                        #region  Crear Country
                        string texto = Microsoft.VisualBasic.Interaction.InputBox(
                        "Texto de la pregunta",
                        "Titulo del diálogo",
                        "Respuesta por defecto");
                        Country country = new Country() { Name = texto };

                        service.Create(country);

                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '2':
                        System.Console.Clear();
                        System.Console.WriteLine("Eliminar Country");
                        #region  Eliminar Country
                        string nombre = "venezuela";
                        Country coun = service.Find(nombre);
                        service.Delete(coun);
                        #endregion
                        System.Console.ReadKey();
                        // Continuar lógica y extraer métodos //
                        break;
                    case '3':
                        System.Console.Clear();
                        System.Console.WriteLine("Listar Country");
                        #region  Listar Country
                        List<Country> countries = service.GetAll().ToList();
                        foreach (var item in countries)
                        {
                            System.Console.WriteLine(item.Name);
                        }
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


        void ConsignarCuentaBancaria(BancoContext context)
        {
            #region  Consignar

            ConsignarService _service = new ConsignarService(new UnitOfWork(context), new CuentaBancariaRepository(context));
            var request = new ConsignarRequest() { NumeroCuenta = "524255", Valor = 1000 };

            ConsignarResponse response = _service.Ejecutar(request);

            System.Console.WriteLine(response.Mensaje);
            #endregion
            System.Console.ReadKey();
        }

        void CrearCuentaBancaria(BancoContext context)
        {
            #region  Crear

            CrearCuentaBancariaService _service = new CrearCuentaBancariaService(new UnitOfWork(context), new CuentaBancariaRepository(context));
            var requestCrer = new CrearCuentaBancariaRequest() { Numero = "524255", Nombre = "Boris Arturo" };

            CrearCuentaBancariaResponse responseCrear = _service.Ejecutar(requestCrer);

            System.Console.WriteLine(responseCrear.Mensaje);
            #endregion
            System.Console.ReadKey();
        }

    }
}
