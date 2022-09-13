
namespace TestDateFormat;

[TestFixture]
public class DataFormatterTests
{
    [Test]
    public void FechaFormatoCorrecto()
    {
        const string expected = "1997-11-10";
        string FechaCorrecta = DateFormatter.ChangeFormat("10-11-1997");
        Assert.AreEqual(expected, FechaCorrecta);

        // En este Test busco validar que pasa cuando la fecha ingresada es en un formato valido y cuando
        // lo ingreso, me hace el cambio de forma correcta

    }

    [Test]
    public void FechaFormatoIncorrecto()
    {

        const string expected = "1997-11-10";
        string fechaIncorrecta = DateFormatter.ChangeFormat("10-1997-11");
        Assert.AreEqual(expected, fechaIncorrecta);

        // En este Test busco validar que pasa cuando la fecha ingresada es en un formato invalido, osea no es 
        // DD/MM/AAAA

        // Cuando me largo error aca al poner el formato incorrecto, ahora en el nuevo codigo voy a pedir que 
        

    }
    [Test]
    public void FechaVacia()
    {

        const string expected = "Porfavor inserte una fecha valida";
        string FechaSinDatos = DateFormatter.ChangeFormat("");
        Assert.AreEqual(expected, FechaSinDatos);

        // En este Test busco validar que pasa cuando la fehca ingresada esta en blanco, osea no se ingresa nada

        // En el nuevo codigo voy a pedir que cuando esta vacio, ingrese una fecha en formato adecuado.

    }
}
