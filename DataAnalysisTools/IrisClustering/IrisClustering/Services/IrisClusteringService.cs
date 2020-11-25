using System;
using System.IO;
using IrisClustering.Data;
using Microsoft.ML;
using Microsoft.ML.Data;

namespace IrisClustering.Services
{
    public class IrisClusteringService
    {
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "Data", "iris.data");
        //static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "IrisClusteringModel.zip");

        private PredictionEngine<IrisData, ClusterPrediction> _predictor;

        public IrisClusteringService(int numberOfClusters)
        {
            var mlContext = new MLContext(seed: 0);

            string featuresColumnName = "Features";
            var pipeline = mlContext.Transforms
                .Concatenate(featuresColumnName, "SepalLength", "SepalWidth", "PetalLength", "PetalWidth")
                .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: numberOfClusters));

            IDataView dataView = mlContext.Data.LoadFromTextFile<IrisData>(_dataPath, hasHeader: false, separatorChar: ',');

            var model = pipeline.Fit(dataView);

            _predictor = mlContext.Model.CreatePredictionEngine<IrisData, ClusterPrediction>(model);
        }

        public ClusterPrediction RunModel(IrisData irisData)
        {
            return _predictor.Predict(irisData);
        }
    }
}
