using _1___256_Shades_of_Gray.Distances;
using System;
using System.Collections.Generic;

namespace _1___256_Shades_of_Gray.Classifiers
{
    public class BasicClassifier : IClassifier
    {
        private IEnumerable<Observation> data;
        private readonly IDistance Distance;

        public BasicClassifier(IDistance distance)
        {
            this.Distance = distance;
        }
        
        public void Train(IEnumerable<Observation> trainingSet)
        {
            this.data = trainingSet;
        }

        public string Predict(int[] pixels)
        {
            Observation currentBest = null;
            var shortest = Double.MaxValue;

            foreach (Observation obs in this.data)
            {
                var dist = this.Distance.Between(obs.Pixels, pixels);
                if (dist < shortest)
                {
                    shortest = dist;
                    currentBest = obs;
                }
            }

            return currentBest.Label;
        }
    }
}
