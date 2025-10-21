using DomainEntities;

namespace Auth
{
    public interface IAuth
    {
        public void RegistrarUsuario(DomainAuth adapterAuth);
        public void IniciarSesionUsuario(DomainAuth adapterAuth);
        public void CambiarContraseña(string usuario, string contraseña);
        

    }
}