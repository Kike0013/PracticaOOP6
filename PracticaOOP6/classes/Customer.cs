using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP6
{
    // Esta dependencia dificulta el mantenimiento y flexibilidad del código.
    public class CustomerRepository
    {
        public void ObtenerClientePorId(int id)
        {
            Console.WriteLine($"ID del cliente: {id}");
        }
    }

    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void MostrarCliente(int id)
        {
            _customerRepository.ObtenerClientePorId(id);
        }
    }

}
