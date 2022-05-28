using FarmSystem.Test1;

namespace FarmSystem.Test2
{
    /// <summary>
    /// Interface which exposes method to milk animals
    /// </summary>
    public interface IMilkableAnimal : IAnimal
    {
        #region Public Methods

        void ProduceMilk();

        #endregion Public Methods
    }
}