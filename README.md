# Quantum Bookstore 🛒📚

Welcome to the **Quantum Bookstore** project — a simple but powerful console-based application written in C#. It simulates a flexible online bookstore that can handle different types of books (like paper books, ebooks, and showcase-only demo books), and it's designed with extensibility in mind.

## ✨ Features

- Add different types of books to the inventory:
  - **Paper Books**: Can be bought and shipped.
  - **EBooks**: Can be bought and sent via email.
  - **Showcase Books**: Display-only, not for sale.
- Store basic book info:
  - ISBN, Title, Author, Year, Price, Stock/FileType (depending on type)
- Remove outdated books that are older than a given number of years.
- Buy a book using its ISBN with email and address:
  - Stock is reduced if it's a paper book.
  - Book is delivered using:
    - `ShippingService` for paper books (mocked).
    - `MailService` for ebooks (mocked).
- All console outputs are prefixed with: **Quantum book store:**

## 📦 Classes Overview

- `Book` (abstract base class)
- `PaperBook`, `EBook`, `ShowcaseBook` (inherit from `Book`)
- `QuantumBookstore` (main inventory logic)
- `ShippingService`, `MailService` (mocked delivery services)
- `QuantumBookstoreFullTest` (test program with sample)

You can add more by modifying the `Main()` method in `QuantumBookstoreFullTest.cs`.

