using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	private static string[] wordList = { "paz", "não", "céu", "ser", "mal", "ver", "mãe", "ego", "dom", "bom", "vir", "dar", "luz", "nós", "réu", "lua", "fim", "pós",
		"dor", "ato", "sol", "vez", "pai", "dia", "rua", "ler", "voz", "lei", "voo", "mau", "mão", "rio", "lar", "som", "rei", "mês", "asa", "amor", "fato", "mito", "viés",
		"você", "ação", "sede", "após", "vida", "casa", "auge", "saga", "medo", "suma", "vovó", "mote", "além", "sina", "tolo", "idem", "urge", "crer", "apto", "zelo", "tudo",
		"ruim", "área", "rude", "cota", "fase", "doce", "logo", "rima", "pelo", "cedo", "meio", "arte", "alma", "meta", "sela", "cela", "teor", "sido", "nojo", "alvo", "foco", 
		"pose", "sair", "base", "vale", "ódio", "agir", "teve", "alto", "todo", "eita", "novo", "ágil", "tese", "alta", "sagaz", "termo", "êxito", "mexer", "nobre", "senso", 
		"afeto", "algoz", "ética", "plena", "mútua", "tênue", "fazer", "assim", "vigor", "sutil", "porém", "seção", "sanar", "poder", "audaz", "ideia", "inato", "moral", "sobre",
		"desde", "muito", "justo", "honra", "torpe", "sonho", "razão", "fútil", "etnia", "ícone", "anexo", "amigo", "égide", "lapso", "haver", "expor", "mútuo", "dengo", "tempo",
		"casal", "hábil", "ávido", "ardil", "pesar", "saber", "causa", "graça", "dizer", "posse", "dever", "brado", "prole", "sendo", "comum", "temor", "ainda", "ânimo",
		"ápice", "ânsia", "ceder", "estar", "digno", "pauta", "culto", "mundo", "censo", "forte", "vício", "valha", "denso", "exceto", "cínico", "âmbito", "índole", "mister", 
		"vereda", "apogeu", "inócuo", "convém", "utopia", "sádico", "escopo", "ênfase", "casual", "mérito", "alusão", "hostil", "anseio", "cético", "legado", "pressa", "gentil", 
		"alheio", "nocivo", "infame", "clichê", "paixão", "defina", "dádiva", "aferir", "astuto", "também", "sessão", "solene", "julgar", "glória", "formal", "hábito", "apreço", 
		"embora", "ímpeto", "eficaz", "ocioso", "dispor", "difuso", "perene", "nuance", "exílio", "lúdico", "objeto", "acesso", "acento", "desejo", "isento", "buscar", 
		"mulher", "cortês", "cobiça", "eximir", "receio", "vulgar", "remoto", "prazer", "fático", "quando", "sempre", "nômade", "empatia", "cônjuge", "embuste", "exceção", "caráter",
		"análogo", "genuíno", "sublime", "família", "pêsames", "apático", "redimir", "astúcia", "pródigo", "cultura", "audácia", "estigma", "recesso", "virtude", "refutar", "icônico", 
		"estável", "cinismo", "mórbido", "trivial", "mitigar", "síntese", "aspecto", "luxúria", "cordial", "sucesso", "alegria", "imputar", "escória", 
		"emergir", "ademais", "deboche", "orgulho", "litígio", "através", "contudo", "coragem", "saudade", "ambíguo", "salutar", "amizade", "sensato", "quimera", "ambição", "excesso",
		"relação", "erudito", "fomento", "imersão", "modesto", "parcial", "colosso", "demanda", "exótico", "ciência", "conciso", "piedade", "volátil", "notório", "bizarro",
		"intenso", "inércia", "ansioso", "emotivo", "sentido", "límpido", "profano", "difusão", "inerente", "respeito", "peculiar", "denegrir", 
		"deferido", "equidade", "prudente", "iminente", "essência", "eminente", "abstrato", "premissa", "extensão", "empírico", "conceito", "ascensão", "reiterar", "relativo", 
		"prodígio", "passível", "conserto", "gratidão", "analogia", "modéstia", "ativista", "inóspito", "monótono", "despeito", "retórica", "concerne", "sinônimo", "proceder",
		"metódico", "história", "portanto", "complexo", "consiste", "critério", "notívago", "distinto", "espectro", "sucumbir", "desfecho", "singular", "suscitar", "paradoxo", "escárnio", "contexto", 
		"processo", "comunhão", "elegível", "vocábulo", "objetivo", "refletir", "impávido", "maestria", "obstante", "desígnio", "problema", "jurídico", "solícito", "instigar", "incrível",
		"epifania", "redenção", "mediante", "paralelo", "insípido", "resoluto", "imanente", "genérico", "perspicaz", "recíproco", "concessão", "impressão", "supérfluo", "retificar", 
		"paradigma", "dicotomia", "propósito", "concepção", "implícito", "plenitude", "essencial", "hegemonia", "corolário", "incidente", "hermético", "aleatório", "esperança", "persuadir", 
		"confiança", "deliberar", "demasiado", "diligente", "impetuoso", "descrição", "resignado", "inusitado", "eminência", "compaixão", "prudência", "pretensão", "discrição", "analítico",
		"explícito", "ordinário", "percepção", "nostalgia", "subjetivo", "autonomia", "companhia", "resolução", "desdenhar", "dissensão", "expressão", "constante", "supressão", "imparcial",
		"autêntico", "paciência", "consoante", "cognitivo", "adjacente", "eloquente", "instância", "interesse", "limítrofe", "sintético", "iminência", "submissão", "presságio", "relevante",
		"excelente", "liberdade", "ludibriar", "aquisição", "ambicioso", "plausível", "humildade", "convicção", "dicionário", "diligência", "detrimento", "maturidade", "parcimônia", "referência",
		"inspiração", "inexorável", "incipiente", "disruptivo", "sororidade", "serenidade", "arbitrário", "indulgente", "auspicioso", "iniquidade", "pertinente", "sagacidade", "resignação",
		"precedente", "vislumbrar", "incidência", "lisonjeado", "suscetível", "entretanto", "disposição", "subestimar", "preliminar", "tribulação", "equivocado", "excelência", "democracia",
		"infortúnio", "compassivo", "contemplar", "importante", "pejorativo", "restringir", "sintetizar", "proposição", "primordial", "conjuntura", "coercitivo", "dissolução", "intrínseca",
		"subjacente", "itinerário", "finalidade", "esplêndido", "alteridade", "espontâneo", "designação", "necessário", "constância", "sarcástico", "privilégio", "desprovido", "pernóstico", 
		"exacerbado", "felicidade", "relevância", "divergente", "disciplina", "inferência", "satisfação", "reverberar", "meticuloso", "esporádico", "influência", "retumbante", "consolidar", "abacate"};


	public static string GetRandomWord ()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}

}
