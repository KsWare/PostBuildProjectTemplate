internal class Program {

	static int Main(string[] args) {
		// -postbuild $(Configuration)

		for (var i = 0; i < args.Length; i++) {
			var cmd = args[i].ToLowerInvariant().Replace('/','-');
			switch (cmd) {
				case "-?": case "-help": return Help();
				case "-postbuild": return PostBuild(args[i + 1]);
			}
		}
		return Help();
	}

	private static int PostBuild(string configuration) {
		//
		// TODO add your post build code here
		//

		return 0;
	}

	private static int Help() {
		//
		// TODO add your help code here
		//

		return 0;
	}

}

