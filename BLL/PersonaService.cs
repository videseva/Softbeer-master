using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        //private PersonaRepository personaRepository;
        public PersonaService()
        {
            //personaRepository = new PersonaRepository();
        }


        public string Guardar(Persona persona)
        {
            
            try
            {
                //falta validar que no exista la persona
                if (true)
                {
                    //personaRepository.Guardar(persona);
                    return "Se ha registrado la persona correctamente!";
                }
                else
                    return "No se pudo registrar a la persona, ya se encuentra registrado.";

            }
            catch (Exception e)
            {
                return RetornarMensajeExcepcion(e);
            }
            
        }
        public string Editar(string cedulaPersonaOld, string cedulaPersonaNew)
        {
            try
            {
                //si existe la persona
                if (true)
                {
                    //personaRepository.Editar(cedulaPersonaOld, cedulaPersonaNew);
                    return "La informacion de la persona fue modificada correctamente.";
                }
                else
                {
                    return "La persona ingresada no se encuentra registrada";
                }
            }
            catch (Exception e)
            {
                return RetornarMensajeExcepcion(e);
            }
        }
        public string Eliminar(string cedulaPersona)
        {
            try
            {
                //si existe la persona
                if (true)
                {
                    //liquidacionRepository.Eliminar(cedulaPersona);
                    return "La persona fue eliminada correctamente.";
                }
                else
                {
                    return "La persona no se encuentra registrada";
                }
            }
            catch (Exception e)
            {
                return RetornarMensajeExcepcion(e);
            }
        }



        private string RetornarMensajeExcepcion(Exception e)
        {
            return "Se han presentado una excepcion. " +
                                "Consulta con el programador el siguiente error: " + e.Message;
        }
    }
}
