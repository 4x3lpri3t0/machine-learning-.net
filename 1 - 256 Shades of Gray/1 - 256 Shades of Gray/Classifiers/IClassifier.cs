using System.Collections.Generic;

namespace _1___256_Shades_of_Gray.Classifiers
{
    public interface IClassifier
    {
        void Train(IEnumerable<Observation> trainingSet);
        string Predict(int[] pixels);
    }
}
