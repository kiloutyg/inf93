import { database } from "./database";

const collection = database.todos;
export const add = (todo) => {
    return [...collection, todo];
};

export const getAll = () => {
    return collection;
};

export const getById = (id) => {
    return collection.find(todo => todo.id === id);
};
export const remove = (id) => {

};