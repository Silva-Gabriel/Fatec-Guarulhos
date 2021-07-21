namespace ProgramandoClasses
{
    public class testCarro
    {
        [Fact]
        public void TestAcelerar()
        {
        //Given
        Carro c1 = new Carro(1000,0);
        //When
        c1.acelerar();
        c1.acelerar();
        c1.acelerar();
        //Then
        Assert.Equals(30,c1.velocidade);
        }
    }
}