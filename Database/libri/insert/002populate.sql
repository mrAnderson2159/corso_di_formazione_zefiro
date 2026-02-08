USE [Libri];
GO

INSERT INTO [dbo].[Libri]
(
    Titolo,
    Autore,
    Categoria,
    NumeroPagine,
    DataPubblicazione,
    Esaurito,
    Fila,
    Scaffale
)
VALUES
('Il nome della rosa', 'Umberto Eco', 'Romanzo', 512, '1980-10-01', 0, 'A', '1'),
('1984', 'George Orwell', 'Distopico', 328, '1949-06-08', 0, 'A', '1'),
('Il signore degli anelli', 'J.R.R. Tolkien', 'Fantasy', 1216, '1954-07-29', 1, 'A', '2'),
('Fahrenheit 451', 'Ray Bradbury', 'Fantascienza', 256, '1953-10-19', 0, 'A', '2'),
('Il piccolo principe', 'Antoine de Saint-Exupéry', 'Narrativa', 96, '1943-04-06', 0, 'B', '1'),
('Orgoglio e pregiudizio', 'Jane Austen', 'Classici', 432, '1813-01-28', 1, 'B', '1'),
('La coscienza di Zeno', 'Italo Svevo', 'Romanzo', 384, '1923-01-01', 0, 'B', '2'),
('Il fu Mattia Pascal', 'Luigi Pirandello', 'Romanzo', 304, '1904-01-01', 0, 'B', '2'),
('Il codice Da Vinci', 'Dan Brown', 'Thriller', 592, '2003-03-18', 0, 'C', '1'),
('Angeli e demoni', 'Dan Brown', 'Thriller', 624, '2000-05-01', 1, 'C', '1'),
('Harry Potter e la pietra filosofale', 'J.K. Rowling', 'Fantasy', 304, '1997-06-26', 0, 'C', '2'),
('Harry Potter e la camera dei segreti', 'J.K. Rowling', 'Fantasy', 336, '1998-07-02', 0, 'C', '2'),
('Il vecchio e il mare', 'Ernest Hemingway', 'Narrativa', 128, '1952-09-01', 0, 'D', '1'),
('Cent''anni di solitudine', 'Gabriel García Márquez', 'Narrativa', 448, '1967-05-30', 1, 'D', '1'),
('Siddharta', 'Hermann Hesse', 'Filosofia', 176, '1922-01-01', 0, 'D', '2'),
('Il processo', 'Franz Kafka', 'Classici', 320, '1925-01-01', 1, 'D', '2'),
('La fattoria degli animali', 'George Orwell', 'Satira', 144, '1945-08-17', 0, 'E', '1'),
('Dune', 'Frank Herbert', 'Fantascienza', 640, '1965-08-01', 0, 'E', '1'),
('Neuromante', 'William Gibson', 'Cyberpunk', 288, '1984-07-01', 1, 'E', '2'),
('Il mondo nuovo', 'Aldous Huxley', 'Distopico', 336, '1932-01-01', 0, 'E', '2');
GO
