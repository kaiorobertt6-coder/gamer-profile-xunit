
using GamerProfile.App;

namespace GamerProfile.Tests
{
    public class PerfilJogadorServiceTests
    {
        [Fact]
        public void GerarTagUsuario_DeveRetornarTagFormatada()
        {
            // Arrange
            var service = new PerfilJogadorService();

            // Act
            var resultado = service.GerarTagUsuario("Nickname", "0000");

            // Assert
            Assert.Equal("Nickname#0000", resultado);
        }

        [Fact]
        public void CalcularXPTotal_DeveSomarXPComBonus()
        {
            // Arrange
            var service = new PerfilJogadorService();

            // Act
            var resultado = service.CalcularXPTotal(200, 300);

            // Assert
            Assert.Equal(600, resultado);
        }

        [Fact]
        public void EEligivelParaRanked_DeveValidarNivelDoJogador()
        {
            // Arrange
            var service = new PerfilJogadorService();

            // Act e Assert
            Assert.True(service.EEligivelParaRanked(15));
            Assert.True(service.EEligivelParaRanked(20));

            Assert.False(service.EEligivelParaRanked(14));
            Assert.False(service.EEligivelParaRanked(10));
        }
    }
}