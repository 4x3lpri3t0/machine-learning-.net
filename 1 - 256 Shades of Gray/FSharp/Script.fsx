﻿open System.IO

type Observation = { Label:string; Pixels: int[] }
type Distance = int[] * int[] -> int
type Classifier = int[] -> string

let toObservation (csvData:string) =
    let columns = csvData.Split(',')
    let label = columns.[0]
    let pixels = columns.[1..] |> Array.map int
    { Label = label; Pixels = pixels }

let reader path = 
    let data = File.ReadAllLines path
    data.[1..]
    |> Array.map toObservation

let trainingPath = @"C:\Users\Axel\Desktop\machine-learning-.net\1 - 256 Shades of Gray\trainingsample.csv"
let trainingData = reader trainingPath

let manhattanDistance (pixels1,pixels2) =
    Array.zip pixels1 pixels2
    |> Array.map (fun (x,y) -> abs (x-y))
    |> Array.sum

let euclideanDistance (pixels1,pixels2) =
    Array.zip pixels1 pixels2
    |> Array.map (fun (x,y) -> pown (x-y) 2)
    |> Array.sum

let train (trainingSet:Observation[]) (dist:Distance) =
    let classify (pixels:int[]) =
        trainingSet
        |> Array.minBy (fun x -> dist (x.Pixels, pixels))
        |> fun x -> x.Label
    classify

let validationPath = @"C:\Users\Axel\Desktop\machine-learning-.net\1 - 256 Shades of Gray\validationsample.csv"
let validationData = reader validationPath

let evaluate validationSet classifier = 
    validationSet
    |> Array.averageBy (fun x -> if classifier x.Pixels = x.Label then 1. else 0.)
    |> printfn "Correct: %.3f"

let manhattanModel = train trainingData manhattanDistance
let euclideanModel = train trainingData euclideanDistance

printfn "Manhattan" // 93.4%
evaluate validationData manhattanModel
printfn "Euclidean" // 94.4%
evaluate validationData euclideanModel

// ... those are 1 Nearest Neighbor models

// Illustration: full distance function
let d (X,Y) = 
    Array.zip X Y 
    |> Array.map (fun (x,y) -> pown (x-y) 2) 
    |> Array.sum 
    |> sqrt