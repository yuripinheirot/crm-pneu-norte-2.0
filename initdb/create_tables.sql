CREATE TYPE pos_sale_type AS ENUM ('order', 'sale');

CREATE TYPE status_type AS ENUM ('pending', 'done');

CREATE TABLE
    questions (
        id UUID PRIMARY KEY,
        description TEXT NOT NULL,
        pos_Sale pos_sale_type NOT NULL,
        active BOOLEAN NOT NULL,
        answers text [] NOT NULL,
        bad_Answers text [] NOT NULL
    );

CREATE TABLE
    answers (
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

ALTER TABLE public.answers
ADD
    CONSTRAINT answers_fk FOREIGN KEY (id_Question) REFERENCES public.questions(id);

INSERT INTO
    public.questions (
        id,
        description,
        pos_sale,
        active,
        answers,
        bad_answers
    )
VALUES (
        '8f2e538a-8cf1-4012-8011-6c3f8f4a085b':: uuid,
        'aqui é uma order',
        'order':: pos_sale_type,
        true,
        '{"sim","nao"}',
        '{"nao"}'
    );

INSERT INTO
    public.questions (
        id,
        description,
        pos_sale,
        active,
        answers,
        bad_answers
    )
VALUES (
        'b3d553c8-48f1-42b6-8c08-9e8658e53a7d':: uuid,
        'aqui é uma segunda order',
        'order':: pos_sale_type,
        true,
        '{"azul","verde"}',
        '{"verde"}'
    );

INSERT INTO
    public.questions (
        id,
        description,
        pos_sale,
        active,
        answers,
        bad_answers
    )
VALUES (
        'a2957f07-9893-4f60-9961-8769fd2f9295':: uuid,
        'aqui é uma sale',
        'sale':: pos_sale_type,
        true,
        '{"sim","nao"}',
        '{"nao"}'
    );

INSERT INTO
    public.questions (
        id,
        description,
        pos_sale,
        active,
        answers,
        bad_answers
    )
VALUES (
        'd95239be-62ff-4b78-8ea1-1f454bf579f9':: uuid,
        'aqui é uma segunda sale',
        'sale':: pos_sale_type,
        true,
        '{"azul","verde"}',
        '{"verde"}'
    );

INSERT INTO
    public.questions (
        id,
        description,
        pos_sale,
        active,
        answers,
        bad_answers
    )
VALUES (
        '99b84ac8-916f-4f53-ac9a-9edcf6df2fbc':: uuid,
        'desativado',
        'sale':: pos_sale_type,
        false,
        '{"azul","verde"}',
        '{"verde"}'
    );