CREATE TABLE IF NOT EXISTS enderecos(
    enderecoId INT PRIMARY KEY AUTO_INCREMENT,
    cidade VARCHAR(150) NOT NULL,
    estado VARCHAR(150) NOT NULL,

    pessoaId INT,
    CONSTRAINT pessoa_fk FOREIGN KEY (pessoaId) REFERENCES pessoas(pessoaId));