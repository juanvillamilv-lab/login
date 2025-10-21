using AdapterEntities;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using serv;

namespace MS_Autenticacion;

[ApiController]
[Route("api/[controller]")]

public class AutControlador : ControllerBase
{
    private readonly AuthServImpl authServImpl;

    public AutControlador(AuthServImpl authServImpl)
    {
        this.authServImpl = authServImpl;
    }

    [HttpPost("usuario")]
    public ActionResult<AdapterAuth> ObtenerUsuario([FromBody] AdapterAuth adapterAuth)
    {
        return Ok(adapterAuth);
    }

    [HttpGet ("login")]
    public ActionResult<AdapterAuth> IniciarSesion(AdapterAuth adapterAuth)
    {
        return Ok(adapterAuth);
    }

    [HttpPost ("register")]
    public ActionResult<AdapterAuth> RegistrarUsuario(AdapterAuth adapterAuth)
    {
        return Ok(adapterAuth);
    }

    [HttpGet ("logout")]
    public string Cerrarcesion()
    {
        return "sesion cerrada ";
    }



}