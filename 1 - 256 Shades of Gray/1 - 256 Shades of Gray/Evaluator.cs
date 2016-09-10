using _1___256_Shades_of_Gray.Classifiers;
using System.Collections.Generic;
using System.Linq;

namespace _1___256_Shades_of_Gray
{
    public class Evaluator
    {
        public static double Correct(
            IEnumerable<Observation> validationSet,
            IClassifier classifier)
        {
            return validationSet
                .Select(obs => Score(obs, classifier))
                .Average();
        }

        private static double Score(
            Observation obs,
            IClassifier classifier)
        {
            if (classifier.Predict(obs.Pixels) == obs.Label)
                return 1.0;
            else
                return 0.0;
        }
    }
}
