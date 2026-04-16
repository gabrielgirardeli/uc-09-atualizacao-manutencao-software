document.addEventListener('DOMContentLoaded', function () {

  // =====================
  // FORMULÁRIO
  // =====================
  const form = document.getElementById('formContato');

  if (form) {
    form.addEventListener('submit', function (e) {
      e.preventDefault();

      const nome = document.getElementById('nome').value.trim();
      const email = document.getElementById('email').value.trim();
      const mensagem = document.getElementById('mensagem').value.trim();

      const emailValido = /\S+@\S+\.\S+/;

      if (!nome || !email || !mensagem) {
        alert('Por favor, preencha todos os campos!');
        return;
      }

      if (!emailValido.test(email)) {
        alert('Digite um email válido!');
        return;
      }

      alert('Mensagem enviada com sucesso!');
      form.reset();
    });
  }

  // =====================
  // MENU MOBILE ✅ ADICIONADO AQUI
  // =====================
  const menuBtn = document.getElementById("menu-btn");
  const menu = document.getElementById("menu");

  if (menuBtn && menu) {
    menuBtn.addEventListener("click", () => {
      menu.classList.toggle("hidden");
    });
  }

  // =====================
  // MENU ATIVO (scroll)
  // =====================
  const sections = document.querySelectorAll('section[id]');
  const navLinks = document.querySelectorAll('nav a');

  window.addEventListener('scroll', function () {
    let current = '';
    const headerOffset = 80;

    sections.forEach(section => {
      if (window.scrollY >= section.offsetTop - headerOffset) {
        current = section.getAttribute('id');
      }
    });

    navLinks.forEach(link => {
      link.classList.remove('active');
      if (link.getAttribute('href') === '#' + current) {
        link.classList.add('active');
      }
    });
  });

  // =====================
  // ANO AUTOMÁTICO
  // =====================
  const anoSpan = document.getElementById('ano');
  if (anoSpan) {
    anoSpan.textContent = new Date().getFullYear();
  }

  // AGENDAMENTO
const formAg = document.getElementById("formAgendamento");

if (formAg) {
  formAg.addEventListener("submit", function (e) {
    e.preventDefault();

    const nome = document.getElementById("nomeAg").value;
    const servico = document.getElementById("servicoAg").value;
    const data = document.getElementById("dataAg").value;
    const hora = document.getElementById("horaAg").value;

    if (!nome || !data || !hora) {
      alert("Preencha todos os campos!");
      return;
    }

    alert(`Agendamento realizado!\n\nNome: ${nome}\nServiço: ${servico}\nData: ${data}\nHorário: ${hora}`);

    formAg.reset();
  });
}

});