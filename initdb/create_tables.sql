CREATE TYPE pos_sale_type AS ENUM ('order', 'sale');

CREATE TYPE status_type AS ENUM ('pending', 'done');

CREATE TABLE
    questions (
        id UUID PRIMARY KEY,
        description TEXT NOT NULL,
        posSale pos_sale_type NOT NULL,
        active BOOLEAN NOT NULL
    );

CREATE TABLE
    answers (
        id UUID PRIMARY KEY,
        idQuestion UUID NOT NULL,
        idSale char(7) NOT NULL,
        idClient char(5) NOT NULL,
        status status_type NOT NULL,
        answer text,
        observation text,
        resolution text,
        updatedAt timestamp without time zone NOT NULL,
        createdAt timestamp without time zone NOT NULL,
        idCompany char(2) NOT NULL
    );