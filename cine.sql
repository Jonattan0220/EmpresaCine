--
-- PostgreSQL database dump
--

-- Dumped from database version 13.6
-- Dumped by pg_dump version 13.6

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: ciudades; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.ciudades (
    id_ciudad integer NOT NULL,
    nombre character varying NOT NULL,
    estado character varying NOT NULL
);


ALTER TABLE public.ciudades OWNER TO postgres;

--
-- Name: ciudades_id_ciudad_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.ciudades_id_ciudad_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.ciudades_id_ciudad_seq OWNER TO postgres;

--
-- Name: ciudades_id_ciudad_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.ciudades_id_ciudad_seq OWNED BY public.ciudades.id_ciudad;


--
-- Name: generos; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.generos (
    id_genero integer NOT NULL,
    nombre character varying NOT NULL,
    estado character varying NOT NULL
);


ALTER TABLE public.generos OWNER TO postgres;

--
-- Name: generos_id_genero_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.generos_id_genero_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.generos_id_genero_seq OWNER TO postgres;

--
-- Name: generos_id_genero_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.generos_id_genero_seq OWNED BY public.generos.id_genero;


--
-- Name: multicines; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.multicines (
    id_multicine integer NOT NULL,
    nombre character varying NOT NULL,
    id_ciudad integer NOT NULL
);


ALTER TABLE public.multicines OWNER TO postgres;

--
-- Name: multicines_id_multicine_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.multicines_id_multicine_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.multicines_id_multicine_seq OWNER TO postgres;

--
-- Name: multicines_id_multicine_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.multicines_id_multicine_seq OWNED BY public.multicines.id_multicine;


--
-- Name: peliculas; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.peliculas (
    id_pelicula integer NOT NULL,
    id_genero integer NOT NULL,
    poster character varying NOT NULL,
    trailer character varying NOT NULL,
    estado character varying NOT NULL
);


ALTER TABLE public.peliculas OWNER TO postgres;

--
-- Name: peliculas_id_pelicula_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.peliculas_id_pelicula_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.peliculas_id_pelicula_seq OWNER TO postgres;

--
-- Name: peliculas_id_pelicula_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.peliculas_id_pelicula_seq OWNED BY public.peliculas.id_pelicula;


--
-- Name: peliculas_multicine; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.peliculas_multicine (
    id_peliculas_multicine integer NOT NULL,
    id_pelicula integer NOT NULL,
    id_multicine integer NOT NULL,
    horario time without time zone NOT NULL
);


ALTER TABLE public.peliculas_multicine OWNER TO postgres;

--
-- Name: peliculas_multicine_id_peliculas_multicine_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.peliculas_multicine_id_peliculas_multicine_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.peliculas_multicine_id_peliculas_multicine_seq OWNER TO postgres;

--
-- Name: peliculas_multicine_id_peliculas_multicine_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.peliculas_multicine_id_peliculas_multicine_seq OWNED BY public.peliculas_multicine.id_peliculas_multicine;


--
-- Name: ciudades id_ciudad; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ciudades ALTER COLUMN id_ciudad SET DEFAULT nextval('public.ciudades_id_ciudad_seq'::regclass);


--
-- Name: generos id_genero; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.generos ALTER COLUMN id_genero SET DEFAULT nextval('public.generos_id_genero_seq'::regclass);


--
-- Name: multicines id_multicine; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.multicines ALTER COLUMN id_multicine SET DEFAULT nextval('public.multicines_id_multicine_seq'::regclass);


--
-- Name: peliculas id_pelicula; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas ALTER COLUMN id_pelicula SET DEFAULT nextval('public.peliculas_id_pelicula_seq'::regclass);


--
-- Name: peliculas_multicine id_peliculas_multicine; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas_multicine ALTER COLUMN id_peliculas_multicine SET DEFAULT nextval('public.peliculas_multicine_id_peliculas_multicine_seq'::regclass);


--
-- Data for Name: ciudades; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.ciudades (id_ciudad, nombre, estado) FROM stdin;
2	Barranquilla	Activo
1	Tunja	Activo
3	Tolemaida	Activo
\.


--
-- Data for Name: generos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.generos (id_genero, nombre, estado) FROM stdin;
1	Terror	Activo
\.


--
-- Data for Name: multicines; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.multicines (id_multicine, nombre, id_ciudad) FROM stdin;
1	MulticineFamoso	1
\.


--
-- Data for Name: peliculas; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.peliculas (id_pelicula, id_genero, poster, trailer, estado) FROM stdin;
1	1	https://cdn.pixabay.com/photo/2016/03/21/23/25/link-1271843_960_720.png	https://www.youtube.com/watch?v=rk72A5wzARU&ab_channel=TheCoderCaveesp	Activo
\.


--
-- Data for Name: peliculas_multicine; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.peliculas_multicine (id_peliculas_multicine, id_pelicula, id_multicine, horario) FROM stdin;
1	1	1	08:00:00
\.


--
-- Name: ciudades_id_ciudad_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.ciudades_id_ciudad_seq', 3, true);


--
-- Name: generos_id_genero_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.generos_id_genero_seq', 1, true);


--
-- Name: multicines_id_multicine_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.multicines_id_multicine_seq', 1, true);


--
-- Name: peliculas_id_pelicula_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.peliculas_id_pelicula_seq', 1, true);


--
-- Name: peliculas_multicine_id_peliculas_multicine_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.peliculas_multicine_id_peliculas_multicine_seq', 1, true);


--
-- Name: ciudades ciudades_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.ciudades
    ADD CONSTRAINT ciudades_pkey PRIMARY KEY (id_ciudad);


--
-- Name: generos generos_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.generos
    ADD CONSTRAINT generos_pkey PRIMARY KEY (id_genero);


--
-- Name: multicines multicines_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.multicines
    ADD CONSTRAINT multicines_pkey PRIMARY KEY (id_multicine);


--
-- Name: peliculas_multicine peliculas_multicine_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas_multicine
    ADD CONSTRAINT peliculas_multicine_pkey PRIMARY KEY (id_peliculas_multicine);


--
-- Name: peliculas peliculas_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas
    ADD CONSTRAINT peliculas_pkey PRIMARY KEY (id_pelicula);


--
-- Name: multicines multicines_id_ciudad_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.multicines
    ADD CONSTRAINT multicines_id_ciudad_fkey FOREIGN KEY (id_ciudad) REFERENCES public.ciudades(id_ciudad) ON DELETE CASCADE;


--
-- Name: peliculas peliculas_id_genero_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas
    ADD CONSTRAINT peliculas_id_genero_fkey FOREIGN KEY (id_genero) REFERENCES public.generos(id_genero) ON DELETE CASCADE;


--
-- Name: peliculas_multicine peliculas_multicine_id_multicine_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas_multicine
    ADD CONSTRAINT peliculas_multicine_id_multicine_fkey FOREIGN KEY (id_multicine) REFERENCES public.multicines(id_multicine) ON DELETE CASCADE;


--
-- Name: peliculas_multicine peliculas_multicine_id_pelicula_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.peliculas_multicine
    ADD CONSTRAINT peliculas_multicine_id_pelicula_fkey FOREIGN KEY (id_pelicula) REFERENCES public.peliculas(id_pelicula) ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

