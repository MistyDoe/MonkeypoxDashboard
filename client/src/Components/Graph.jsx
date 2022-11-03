import { useEffect } from "react";
import { useState } from "react";
import {
	LineChart,
	Line,
	CartesianGrid,
	YAxis,
	XAxis,
	Tooltip,
	Legend,
} from "recharts";
import "../App.css";

export default function Graph({ country }) {
	const [countryName, SetCountryName] = useState();
	const [countryData, setCountryData] = useState();

	useEffect(() => {
		SetCountryName(country);
	});

	useEffect(() => {
		console.log(countryName);
		fetch("http://localhost:5152/api/Case/" + countryName)
			.then((res) => res.json())
			.then((json) => {
				setCountryData(json);
			});
	}, [countryName]);

	if (countryData === undefined) {
		return <div> No Data</div>;
	}

	return (
		<>
			<div className=".graph">
				<div> Cases for {countryName} </div>
				<div>
					<LineChart
						width={730}
						height={250}
						data={countryData}
						margin={{ top: 5, right: 30, left: 20, bottom: 5 }}
					>
						<CartesianGrid strokeDasharray="3 3" />
						<XAxis dataKey="date" hide="true" />
						<YAxis />
						<Tooltip />
						<Legend />
						<Line type="monotone" dataKey="total_cases" stroke="#8884d8" />
					</LineChart>
				</div>
			</div>
		</>
	);
}
