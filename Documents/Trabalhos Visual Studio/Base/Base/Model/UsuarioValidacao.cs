using FluentValidation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class UsuarioValidacao : AbstractValidator<Usuario>
    {
        public UsuarioValidacao()
        {
            RuleFor(x => x.NomeUsuario).Length(3, 50).WithMessage("Informe o nome do usuário (3 a 50 caracteres)");
            RuleFor(x => x.Endereco).Length(3, 70).WithMessage("Informe o endereço");
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Senha).Length(3, 30).WithMessage("Informe a senha (3 a 30 caracteres)");
        }
    }
}
