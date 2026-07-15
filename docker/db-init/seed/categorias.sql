SET XACT_ABORT ON;
BEGIN TRANSACTION;

IF NOT EXISTS (SELECT 1 FROM Finanzas.Categorias)
BEGIN
    INSERT INTO Finanzas.Categorias (Id, Nombre, Descripcion, Activo, FechaCreacion) VALUES
    ('11111111-1111-1111-1111-111111111101', 'Alimentacion',    'Gastos en comida y supermercado',         1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111102', 'Transporte',      'Transporte publico, gasolina, mantenimiento', 1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111103', 'Vivienda',        'Alquiler, hipoteca, servicios del hogar',  1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111104', 'Salud',           'Medico, farmacia, seguros',                1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111105', 'Educacion',       'Cursos, libros, matricula',                1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111106', 'Entretenimiento', 'Cine, restaurantes, suscripciones',        1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111107', 'Servicios',       'Luz, agua, gas, internet, telefono',       1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111108', 'Salario',         'Ingreso salarial principal',               1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111109', 'Inversiones',     'Rendimientos, dividendos, intereses',      1, GETUTCDATE()),
    ('11111111-1111-1111-1111-111111111110', 'Otros',           'Gastos e ingresos varios',                 1, GETUTCDATE());
    PRINT 'Categorias parametrizadas insertadas.';
END
ELSE
    PRINT 'Las categorias ya existen, no se insertan duplicados.';

COMMIT;
