# Sorting Algorithms

This repository is a showcase for different sorting algorithms, created for teaching purposes. The algorithms are implemented in C# and aim to provide a clear understanding of how each sorting method works.

## Table of Contents

- [Introduction](#introduction)
- [Algorithms Implemented](#algorithms-implemented)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Introduction

Sorting algorithms are fundamental to computer science and are used to arrange elements in a particular order. This repository demonstrates various sorting algorithms to help students and enthusiasts learn and understand their implementation and behavior.

## Algorithms Implemented

The following sorting algorithms are included in this repository:

1. **Bubble Sort**: A simple comparison-based algorithm where each pair of adjacent elements is compared and swapped if they are in the wrong order.
2. **Selection Sort**: An algorithm that divides the input list into two parts: a sorted sublist of items which is built up from left to right, and a sublist of the remaining unsorted items.
3. **Insertion Sort**: Builds the final sorted array one item at a time, with the assumption that the initial items are already sorted.
4. **Merge Sort**: A divide-and-conquer algorithm that splits the list into smaller sublists, sorts them, and then merges them back together.
5. **Quick Sort**: Another divide-and-conquer algorithm that picks an element as a pivot and partitions the array around the pivot.

## Usage

To run any of the sorting algorithms, you need to have .NET installed on your machine. Follow these steps:

1. **Clone the repository**:
   ```sh
   git clone https://github.com/Cal-ly/SortingAlgorithms.git
   cd SortingAlgorithms
   ```

2. **Build the project**:
   ```sh
   dotnet build
   ```

3. **Run the sorting algorithms**:
   ```sh
   dotnet run
   ```

Each algorithm is implemented in a separate class file. You can find the implementations under the `Algorithms` directory.

## Contributing

Contributions are welcome! If you'd like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/your-feature`).
3. Make your changes.
4. Commit your changes (`git commit -m 'Add some feature'`).
5. Push to the branch (`git push origin feature/your-feature`).
6. Open a pull request.

Please ensure your code adheres to the coding standards and include relevant tests.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
