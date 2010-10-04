package mapeamento
{
	[RemoteClass(alias="IntegracaoFlex.Person")]
	public class Person
	{
		private var id:int;		
		public function get Id():int { return this.id; }		
		public function set Id(valor:int):void { this.id = valor; }
		
		private var name:String;		
		public function get Name():String { return this.name; }		
		public function set Name(valor:String):void { this.name = valor; }
		
		private var phone:String;
		public function get Phone():String { return this.phone; }		
		public function set Phone(valor:String):void { this.phone = valor; }		
		
		public function Person()
		{
			
		}		
	}
}