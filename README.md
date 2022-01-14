# Teste Desenvolvedor C#

O projeto foi criado usando o .net core 3.1.
O acesso a dados esta configurado para usar um banco de dados em memória, mas fique a vontade caso queira usar um banco de dados local, o importante é ter as implementações solicidas neste documento.

# Atividades

   # IoC
   * Implementar injeção de dependência no projeto
   # Autenticação
   * Implementar autenticação JWT. Para esse projeto não é necessário criar o REVOKE TOKEN.
   * O Token deve ter 15 minutos de duração
   # Swagger UI
   * Implementar documentação do Swagger no projeto
   # Autenticador/Login
   * Este endpoint deverá ter as seguintes implementações: 
      * criar um serviço chamado UsuariosService e uma interface chamada IUsuariosService
      * criar um método chamado DoLogin recendo como parametros o email e senha e implementar as regras abaixo: 
        * (usuario: prova@doubleit.com.br, senha: Prova@DoubleIt21, nome: Candidato)
      * validar se as credenciais do usuário estão corretas através de uma consulta ao banco de dados passando email e senha
      * caso não existe uma mensagem de Usuario não encontrado" deverá ser informada
      * caso exista deverá criar um token e adicionar uma claim chamada "user" passando o objeto usuario vindo do banco de dados
      * retornar um token valido
   # Categorias
   * Este endpoint deverá ter as seguintes implementações: 
      * criar um serviço chamado CategoriesService e uma interface chamada ICategoriesService
      * criar um método chamado GetAll sem nenhum parametro e retornar uma lista de Categorias.
      * criar um método chamado Add recebendo um objeto do tipo Categorias e implementar as regras abaixo:
      * validar se o campo Nome foi preenchido e retornar mensagem de erro caso estiver vazio.
      * validar se a categoria existe com o mesmo nome informado.
      * gravar no banco de dados a nova categoria
   # Produtos
   * Este endpoint deverá ter as seguintes implementações: 
     * criar um serviço chamado ProductsService e uma interface chamada IProductsService
     * criar um método chamado GetAll recebenco como parametro o term, page, e pageSize. O método deve retornar uma lista de Produtos.
      * implementar paginação
      * fazer filtro usando o parâmetro term usando o Contains nas propriedades Nome e Categoria.Nome
     * criar um método chamado Add recebendo um objeto do tipo Produtos e implementar as regras abaixo:
      * validar se o campo Nome foi preenchido e retornar mensagem de erro caso estiver vazio.
      * validar se a produto existe com o mesmo nome informado.
      * validar se o preço unitario é > 0 e retornar mensagem de erro caso resultado for false.
      * validar se o quantidade é > 0 e retornar mensagem de erro caso resultado for false.
      * gravar no banco de dados do novo produto.
     * criar um método chamado Update recebendo um objeto do tipo Produtos e implementar as regras abaixo:
      * validar se o produto id informado existe no banco de dados e retornar mensagem de erro caso não tenha sido encontrado.
      * validar se o campo Nome foi preenchido e retornar mensagem de erro caso estiver vazio.
      * validar se o preço unitario é > 0 e retornar mensagem de erro caso resultado for false.
      * validar se o quantidade é > 0 e retornar mensagem de erro caso resultado for false.
      * gravar no banco de dados o produto atualizado.
     * criar um método chamado Delete recebendo o id do produto e implementar as regras abaixo:
      * buscar o produto pelo id e retornar mensagem de erro caso não tenha sido encontrado.
      * caso encontrado deleta o produto do banco de dados.
   # Testes
   * Implementar testes unitários para cada um dos métodos do serviço ProductsService
          
          
    
    


  



