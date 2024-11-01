using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOOP6.classes
{

    // Esta implementeación soluciona el conflicto de la dependencia directa

    public interface ICustomerRepository
    {
        void ObtenerClientePorId(int id);
    }

    // Implementación concreta de la interfaz creada
    public class CustomerRepository : ICustomerRepository
    {
        public void ObtenerClientePorId(int id)
        {
            Console.WriteLine($"ID del cliente: {id}");
        }
    }

    // CustomerService depende ahora de la interfaz ICustomerRepository
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void MostrarCliente(int id)
        {
            _customerRepository.ObtenerClientePorId(id);
        }
    }

}
