Create Database PortafolioE

CREATE TABLE Perfil
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombres VARCHAR(50) NOT NULL,
    Apellidos VARCHAR(50) NOT NULL,
    Telefono NUMERIC
);

CREATE PROCEDURE SP_InsertarAlumno
    @Nombres VARCHAR(50),
    @Apellidos VARCHAR(50),
    @Telefono NUMERIC
AS
BEGIN
    INSERT INTO Perfil (Nombres, Apellidos, Telefono)
    VALUES (@Nombres, @Apellidos, @Telefono);
END;

Create procedure sp_listar
as
begin
	select * from Perfil;
end

exec SP_InsertarAlumno
@Nombres = 'Eduardo Enrique',
@Apellidos = 'Santoyo Aguilera',
@Telefono = 6442558595;

SELECT * FROM Perfil