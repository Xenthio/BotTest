namespace BotTest;

public class TextGenerationParameters
{
	public int max_new_tokens;
	public bool do_sample;
	public double seed;
	public double temperature;
	public double top_k;
	public double top_p;
	public double min_p;
	public double typical_p;
	public double repetition_penalty;
	public double encoder_repetition_penalty;
	public double num_beams;
	public double penalty_alpha;
	public double min_length;
	public double length_penalty;
	public double no_repeat_ngram_size;
	public bool early_stopping;
	public string[] stopping_strings;
	public bool add_bos_token;
	public bool ban_eos_token;
	public bool skip_special_tokens;
}
