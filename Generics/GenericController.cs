public class GenericController<T>
{
    private readonly GenericRepository<T> _repository;
    private readonly GenericView<T> _view;
    private readonly GenericServive<T> _service;

    public GenericController(GenericRepository<T> repo, GenericView<T> view, GenericServive<T> service)
    {
        _repository = repo;
        _view = view;
        _service = service;
    }

    public void Cadastrar(T item) => _repository.Add(item);
    
    public void Processar(string titulo, string arquivoCsv, string cabecalho, Func<T, string> regraConversao)
    {
        var dados = _repository.GetAll();
        _view.Mostrar(titulo, dados);
        _service.Exportar(arquivoCsv,dados, cabecalho, regraConversao);
    }
}
