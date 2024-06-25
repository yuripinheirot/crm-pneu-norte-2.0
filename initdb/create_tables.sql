CREATE SCHEMA crm;

CREATE TYPE pos_sale_type AS ENUM ('order', 'sale');

CREATE TYPE status_type AS ENUM ('pending', 'done');

CREATE TABLE
    crm.questions (
        id UUID PRIMARY KEY,
        description TEXT NOT NULL,
        pos_Sale pos_sale_type NOT NULL,
        active BOOLEAN NOT NULL,
        answers text [] NOT NULL,
        bad_Answers text [] NOT NULL
    );

CREATE TABLE
    crm.answers (
        id UUID PRIMARY KEY,
        id_Question UUID NOT NULL,
        id_Sale char(7) NOT NULL,
        id_Client char(5) NOT NULL,
        status status_type NOT NULL,
        answer text,
        observation text,
        resolution text,
        updated_At timestamp without time zone NOT NULL,
        created_At timestamp without time zone NOT NULL,
        id_Company char(2) NOT NULL
    );


CREATE TABLE crm.doblist (
    id UUID PRIMARY KEY,
    id_client CHAR(5) NOT NULL,
    observations TEXT,
    done BOOLEAN NOT NULL,
    dob varchar(5) NOT NULL,
    year int not null,
    updated_at TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT now(),
    created_at TIMESTAMP WITHOUT TIME ZONE NOT NULL DEFAULT now(),
    UNIQUE (id_client, dob)
);

ALTER TABLE crm.answers
ADD
    CONSTRAINT answers_fk FOREIGN KEY (id_Question) REFERENCES crm.questions(id);