using System.Collections.Generic;
using ShapeLibrary.Model.Abstract;

namespace ShapeLibrary.Factory
{
    public abstract class RandomFactory
    {
        protected const int MAX_DIMENSION_SIZE = 100;
        private int _numberOfItemsToCreate = 0;

        public RandomFactory Create(int howMany)
        {
            _numberOfItemsToCreate = howMany;
            return this;
        }

        public IList<object> Random()
        {
            if (_numberOfItemsToCreate < 1)
                throw new ShapeFactoryException("You much specify how many shapes you want to create.");

            return CreateRandom(_numberOfItemsToCreate);
       
        }

        protected abstract IList<object> CreateRandom(int count);
    }
}
