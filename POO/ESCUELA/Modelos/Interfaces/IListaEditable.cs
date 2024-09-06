namespace ESCUELA.Modelos.Interfaces
{
    public interface IListaEditable<T> where T : class //T Es un valor generico que puede ser CUALQUIER cosa
    {
        void Añadir(T entity); //inferidad de tipo
        void Quitar(T entity);
    }
}
