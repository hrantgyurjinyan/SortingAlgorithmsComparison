# Sorting Algorithm Comparison

This project demonstrates a comparison of different sorting algorithms implemented in C#. It provides an interactive interface to input an array of numbers and compare the execution times of Insertion Sort, Quick Sort, and Heap Sort.

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#usage)
- [Sorting Algorithms](#sorting-algorithms)
  - [Insertion Sort](#insertion-sort)
  - [Quick Sort](#quick-sort)
  - [Heap Sort](#heap-sort)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgements](#acknowledgements)

## Overview

The Sorting Algorithm Comparison project provides a platform to test and compare the performance of different sorting algorithms. It includes implementations of Insertion Sort, Quick Sort, and Heap Sort, each with their respective templates following the Template Method design pattern.

## Features

- Interactive interface for inputting arrays of numbers.
- Comparison of execution times for Insertion Sort, Quick Sort, and Heap Sort.
- Error handling for invalid inputs.
- Modular design with clear separation of sorting algorithms.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/hrantgyurjinyan/sorting-algorithm-comparison.git
   ```
2. Navigate to the project directory:
   ```bash
   cd sorting-algorithm-comparison
   ```
3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

1. Run the application:
   ```bash
   dotnet run
   ```
2. Input an array of numbers when prompted.
3. View the sorted array and the execution times for each sorting algorithm.

## Sorting Algorithms

### Insertion Sort

The Insertion Sort algorithm iterates through the input array, comparing each element with the sorted portion of the array to place it in its correct position.

### Quick Sort

Quick Sort is a divide-and-conquer algorithm that recursively divides the array into smaller subarrays, sorts them, and then combines them to create a sorted array.

### Heap Sort

Heap Sort uses a binary heap data structure to sort the array. It builds a max heap and then repeatedly extracts the maximum element to form the sorted array.

## Contributing

Contributions are welcome! If you have suggestions, improvements, or feature requests, please open an issue or create a pull request.
